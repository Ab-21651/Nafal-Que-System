using Google.Cloud.Firestore;
using System;
using System.Windows.Forms;

namespace fse_project
{
    public partial class TasbeehCounterForm : Form
    {
        private int count = 0;
        private string userEmail;
        private FirestoreDb db;

        public TasbeehCounterForm(string email)
        {
            InitializeComponent();
            userEmail = email;
            db = FirestoreDb.Create("naflqueue");
            LoadCountFromFirestore();
        }

        private async void LoadCountFromFirestore()
        {
            try
            {
                Query query = db.Collection("users").WhereEqualTo("Email", userEmail);
                QuerySnapshot snapshot = await query.GetSnapshotAsync();

                if (snapshot.Count > 0)
                {
                    DocumentSnapshot doc = snapshot.Documents[0];
                    if (doc.ContainsField("tasbeehCount"))
                    {
                        count = doc.GetValue<int>("tasbeehCount");
                        labelCount.Text = count.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load tasbeeh count: " + ex.Message);
            }
        }

        private void buttonIncrement_Click(object sender, EventArgs e)
        {
            count++;
            labelCount.Text = count.ToString();
        }

        private async void TasbeehCounterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Query query = db.Collection("users").WhereEqualTo("Email", userEmail);
                QuerySnapshot snapshot = await query.GetSnapshotAsync();

                if (snapshot.Count > 0)
                {
                    DocumentReference userRef = snapshot.Documents[0].Reference;
                    await userRef.UpdateAsync("tasbeehCount", count);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save tasbeeh count: " + ex.Message);
            }

            this.Owner?.Show();
        }
    }
}
