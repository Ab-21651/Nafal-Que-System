// ✅ BookingForm.cs - Handles slot booking (shared slots per place, with booking limit per user)
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace fse_project
{
    public partial class BookingForm : Form
    {
        private FirestoreDb db;
        private string userEmail;
        private string selectedPlace;
        private int allowedSlots;
        private int allowedBookings;

        public BookingForm(string email, string place, int slots, int bookingsAllowed)
        {
            InitializeComponent();
            userEmail = email;
            selectedPlace = place;
            allowedSlots = slots;
            allowedBookings = bookingsAllowed;

            InitializeFirebase();
            LoadPlaceDetails();
            LoadBookingCount();
        }

        private void InitializeFirebase()
        {
            db = FirestoreDb.Create("naflqueue");
        }

        private async void LoadPlaceDetails()
        {
            try
            {
                CollectionReference slotsRef = db.Collection("places").Document(selectedPlace).Collection("slots");
                QuerySnapshot slotsSnapshot = await slotsRef.GetSnapshotAsync();

                listBoxSlots.Items.Clear();
                int count = 0;

                foreach (var slot in slotsSnapshot.Documents)
                {
                    string slotTime = slot.GetValue<string>("time");
                    bool isBooked = slot.ContainsField("booked") && slot.GetValue<bool>("booked");

                    if (!isBooked && count < allowedSlots)
                    {
                        listBoxSlots.Items.Add(slotTime);
                        count++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading slots: " + ex.Message);
            }
        }

        private async void LoadBookingCount()
        {
            try
            {
                CollectionReference bookingsRef = db.Collection("bookings");
                Query query = bookingsRef.WhereEqualTo("email", userEmail);
                QuerySnapshot snapshot = await query.GetSnapshotAsync();

                int currentBookings = snapshot.Count;
                labelBookingStatus.Text = $"Bookings: {currentBookings}/{allowedBookings}";

                if (currentBookings >= allowedBookings)
                {
                    MessageBox.Show("You have reached the maximum allowed bookings.");
                    buttonBook.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking bookings: " + ex.Message);
            }
        }

        private async void buttonBook_Click(object sender, EventArgs e)
        {
            if (listBoxSlots.SelectedItem == null)
            {
                MessageBox.Show("Please select a time slot!");
                return;
            }

            string selectedSlotTime = listBoxSlots.SelectedItem.ToString();

            try
            {
                // Look for slot document by its 'time' field manually (not by ID)
                CollectionReference slotsRef = db.Collection("places").Document(selectedPlace).Collection("slots");
                Query slotQuery = slotsRef.WhereEqualTo("time", selectedSlotTime);
                QuerySnapshot querySnapshot = await slotQuery.GetSnapshotAsync();

                if (querySnapshot.Count == 0)
                {
                    MessageBox.Show("Slot not found.");
                    return;
                }

                DocumentSnapshot slotDoc = querySnapshot.Documents[0];
                bool isBooked = slotDoc.ContainsField("booked") && slotDoc.GetValue<bool>("booked");

                if (isBooked)
                {
                    MessageBox.Show("This slot is already booked.");
                    return;
                }

                // Mark slot as booked
                await slotDoc.Reference.UpdateAsync("booked", true);

                // Save booking in bookings collection
                await db.Collection("bookings").AddAsync(new
                {
                    email = userEmail,
                    place = selectedPlace,
                    slot = selectedSlotTime,
                    bookedAt = Timestamp.GetCurrentTimestamp()
                });

                DashboardForm.AddNotification($"You booked {selectedSlotTime} at {selectedPlace}.");
                MessageBox.Show("Booking successful!");

                LoadPlaceDetails();
                LoadBookingCount();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error booking slot: " + ex.Message);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Owner?.Show(); // return to dashboard
            this.Close();
        }


    }
}
