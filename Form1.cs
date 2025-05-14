// ✅ Login.cs - Handles login and passes subscription info
using System;
using System.Windows.Forms;
using FirebaseAdmin;
using FirebaseAdmin.Auth;
using Google.Cloud.Firestore;
using Google.Apis.Auth.OAuth2;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace fse_project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            InitializeFirebase();
        }

        private void InitializeFirebase()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "naflqueue-firebase-adminsdk-fbsvc-dffb95e1ca.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            if (FirebaseApp.DefaultInstance == null)
            {
                FirebaseApp.Create(new AppOptions
                {
                    Credential = GoogleCredential.FromFile(path)
                });
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text.Trim();
            string password = textBox2.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both email and password.");
                return;
            }

            try
            {
                FirestoreDb db = FirestoreDb.Create("naflqueue");
                UserRecord user = await FirebaseAuth.DefaultInstance.GetUserByEmailAsync(email);
                string userId = user.Uid;

                DocumentReference docRef = db.Collection("users").Document(userId);
                DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();

                string storedPassword = snapshot.GetValue<string>("Password");

                if (password != storedPassword)
                {
                    MessageBox.Show("Incorrect password.");
                    return;
                }

                string subscriptionType = snapshot.ContainsField("SubscriptionType") ? snapshot.GetValue<string>("SubscriptionType") : "Basic";
                SubscriptionDetails details = SubscriptionDetails.GetDetails(subscriptionType);

                DashboardForm dashboard = new DashboardForm(email, subscriptionType, details.Places, details.Slots, details.BookingsAllowed);
                dashboard.FormClosed += (s, args) => this.Show(); // go back to login if dashboard closes
                this.Hide();
                dashboard.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Login failed: " + ex.Message);
            }
        }

        // Restored missing designer-linked event handlers
        private async void label5_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter your email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string apiKey = "AIzaSyAO67YzV3-WT7oQrmypiw23u64ZwA1HB80"; // 🔥 Replace with your Firebase Web API Key
                string requestUrl = $"https://identitytoolkit.googleapis.com/v1/accounts:sendOobCode?key={apiKey}";

                var payload = new
                {
                    requestType = "PASSWORD_RESET",
                    email = email
                };

                var content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");

                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.PostAsync(requestUrl, content);
                    string responseString = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Password reset email sent! Check your inbox.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error: " + responseString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            SignUp signUpForm = new SignUp();
            signUpForm.Show();
            this.Hide();
        }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
    }

    public class SubscriptionDetails
    {
        public int Places { get; set; }
        public int Slots { get; set; }
        public int BookingsAllowed { get; set; }

        public static SubscriptionDetails GetDetails(string type)
        {
            switch (type)
            {
                case "Standard":
                    return new SubscriptionDetails { Places = 4, Slots = 9, BookingsAllowed = 4 };
                case "Premium":
                    return new SubscriptionDetails { Places = 5, Slots = 15, BookingsAllowed = 6 };
                default:
                    return new SubscriptionDetails { Places = 2, Slots = 6, BookingsAllowed = 2 };
            }
        }
    }
}
