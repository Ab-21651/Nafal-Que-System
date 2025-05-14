using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace fse_project
{
    public partial class CancelSlotForm : Form
    {
        private FirestoreDb db;
        private string userEmail;
        private string subscriptionType;
        private int allowedPlaces;
        private int allowedSlots;
        private int allowedBookings;

        private Dictionary<string, (string place, string docId)> slotLookup = new Dictionary<string, (string, string)>();
        private List<string> allPlaces = new List<string>
        {
            "Gate 36", "Near the Black Stone (Hajar al-Aswad)", "Raudah",
            "Rukun al-Shami and Rukun al-Yamani", "The Multazam"
        };

        public CancelSlotForm(string email, string subType, int places, int slots, int bookings)
        {
            InitializeComponent();
            userEmail = email;
            subscriptionType = subType;
            allowedPlaces = places;
            allowedSlots = slots;
            allowedBookings = bookings;

            InitializeFirebase();
            LoadAvailablePlaces(); // load only allowed places
        }

        private void InitializeFirebase()
        {
            db = FirestoreDb.Create("naflqueue");
        }

        private void LoadAvailablePlaces()
        {
            listBoxPlaces.Items.Clear();

            for (int i = 0; i < Math.Min(allowedPlaces, allPlaces.Count); i++)
            {
                listBoxPlaces.Items.Add(allPlaces[i]);
            }
        }

        private async void listBoxPlaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPlaces.SelectedItem == null)
                return;

            string selectedPlace = listBoxPlaces.SelectedItem.ToString();
            listBoxBookedSlots.Items.Clear();
            slotLookup.Clear();

            try
            {
                CollectionReference bookingsRef = db.Collection("bookings");
                Query query = bookingsRef
                    .WhereEqualTo("email", userEmail)
                    .WhereEqualTo("place", selectedPlace);

                QuerySnapshot snapshot = await query.GetSnapshotAsync();

                foreach (var booking in snapshot.Documents)
                {
                    string slot = booking.GetValue<string>("slot");
                    string docId = booking.Id;

                    listBoxBookedSlots.Items.Add(slot); // show slot only
                    slotLookup[slot] = (selectedPlace, docId); // store full info
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bookings: " + ex.Message);
            }
        }

        private async void buttonCancelBooking_Click(object sender, EventArgs e)
        {
            if (listBoxBookedSlots.SelectedItem == null)
            {
                MessageBox.Show("Please select a booking to cancel!");
                return;
            }

            string slot = listBoxBookedSlots.SelectedItem.ToString();

            if (!slotLookup.TryGetValue(slot, out var data))
            {
                MessageBox.Show("Slot details not found.");
                return;
            }

            string place = data.place;
            string docId = data.docId;

            DialogResult result = MessageBox.Show($"Are you sure you want to cancel {slot} at {place}?", "Confirm", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes) return;

            try
            {
                CollectionReference slotCollection = db.Collection("places").Document(place).Collection("slots");
                Query query = slotCollection.WhereEqualTo("time", slot);
                QuerySnapshot querySnapshot = await query.GetSnapshotAsync();

                if (querySnapshot.Count == 0)
                {
                    MessageBox.Show("Matching slot not found in Firestore.");
                    return;
                }

                DocumentReference slotRef = querySnapshot.Documents[0].Reference;
                await slotRef.UpdateAsync("booked", false);

                DocumentReference bookingDoc = db.Collection("bookings").Document(docId);
                await bookingDoc.DeleteAsync();

                listBoxBookedSlots.Items.Remove(slot);
                slotLookup.Remove(slot);

                MessageBox.Show("Booking canceled successfully!");
                DashboardForm.AddNotification($"You canceled {slot} at {place}.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error canceling slot: " + ex.Message);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Owner?.Show(); // show DashboardForm
            this.Close();
        }


        private void label1_Click(object sender, EventArgs e) { }
        private void listBoxBookedSlots_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}
