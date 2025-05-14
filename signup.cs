using System;
using System.Windows.Forms;
using FirebaseAdmin;
using FirebaseAdmin.Auth;
using Google.Cloud.Firestore;
using Google.Apis.Auth.OAuth2;

namespace fse_project
{
    public partial class SignUp : Form
    {
        FirestoreDb db;

        public string Email { get; private set; }

        public SignUp()
        {
            InitializeComponent();
            InitializeFirebase();
        }

        // Initialize Firebase (Auth & Firestore)
        private void InitializeFirebase()
        {
            try
            {
                string path = AppDomain.CurrentDomain.BaseDirectory + "naflqueue-firebase-adminsdk-fbsvc-dffb95e1ca.json";
                Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

                if (FirebaseApp.DefaultInstance == null)
                {
                    FirebaseApp.Create(new AppOptions()
                    {
                        Credential = GoogleCredential.FromFile(path)
                    });
                }

                db = FirestoreDb.Create("naflqueue");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Firebase Initialization Failed: " + ex.Message);
            }
        }

        // Sign-Up Button Click - Register User & Save to Firestore
        private async void button1_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text.Trim();
            string age = textBoxAge.Text.Trim();
            string phone = textBoxPhone.Text.Trim();
            string nationality = comboBoxNationality.SelectedItem != null ? comboBoxNationality.SelectedItem.ToString() : "";
            string password = textBoxPassword.Text.Trim();
            string email = textBoxEmail.Text.Trim();

            // Input Validation
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(age) || string.IsNullOrEmpty(phone)
                || string.IsNullOrEmpty(nationality) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(name, @"^[A-Za-z\s]+$"))
            {
                MessageBox.Show("Name should only contain letters.");
                return;
            }

            if (!int.TryParse(age, out int parsedAge) || parsedAge <= 0 || parsedAge > 120)
            {
                MessageBox.Show("Please enter a valid numeric age between 1 and 120.");
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(phone, @"^\d{10,15}$"))
            {
                MessageBox.Show("Phone number must be 10–15 digits.");
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters.");
                return;
            }

            try
            {
                // Register User in Firebase Auth
                UserRecordArgs args = new UserRecordArgs()
                {
                    Email = email,
                    Password = password
                };

                UserRecord userRecord = await FirebaseAuth.DefaultInstance.CreateUserAsync(args);
                string userId = userRecord.Uid;

                // Save to Firestore
                DocumentReference docRef = db.Collection("users").Document(userId);
                await docRef.SetAsync(new
                {
                    Username = name,
                    Age = parsedAge,
                    Phone = phone,
                    Nationality = nationality,
                    Email = email,
                    Password = password, 
                    CreatedAt = Timestamp.GetCurrentTimestamp()
                });


                MessageBox.Show("Registration Successful! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Optional: Clear form
                textBoxName.Clear();
                textBoxAge.Clear();
                textBoxPhone.Clear();
                textBoxPassword.Clear();
                comboBoxNationality.SelectedIndex = -1;

                WelcomeForm welcomeForm = new WelcomeForm(email); // userEmail is string
                welcomeForm.Show();
                this.Hide();

            }
            catch (FirebaseAuthException authEx)
            {
                MessageBox.Show("Authentication Error: " + authEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registration Failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Login Label Click - Open Login Form
        private void label7_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show(); // Open Login form
            this.Hide(); // Hide SignUp form
        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void labelAge_Click(object sender, EventArgs e)
        {

        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelNationality_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelPhone_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxNationality_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelAlreadyHaveAccount_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelEmail_Click(object sender, EventArgs e)
        {

        }
    }
}
