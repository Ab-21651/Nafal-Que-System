
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace fse_project
{
    public partial class ViewForm : Form
    {
        private FirestoreDb db;
        private string userEmail;

        public ViewForm(string email)
        {
            InitializeComponent();
            userEmail = email;
            InitializeFirebase();
            LoadUserBookings();
        }

        private void InitializeFirebase()
        {
            db = FirestoreDb.Create("naflqueue");
        }

        private async void LoadUserBookings()
        {
            try
            {
                CollectionReference bookingsRef = db.Collection("bookings");
                Query userBookingsQuery = bookingsRef.WhereEqualTo("email", userEmail);
                QuerySnapshot bookingsSnapshot = await userBookingsQuery.GetSnapshotAsync();

                listBoxBookedSlots.Items.Clear();

                foreach (var booking in bookingsSnapshot.Documents)
                {
                    string place = booking.GetValue<string>("place");
                    string slot = booking.GetValue<string>("slot");
                    listBoxBookedSlots.Items.Add($"{slot} @ {place}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading your bookings: " + ex.Message);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardForm = new DashboardForm(userEmail, "", 0, 0, 0);
            dashboardForm.Show();
            this.Hide();
        }

        private void listBoxBookedSlots_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}
