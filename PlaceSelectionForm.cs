// ✅ PlaceSelectionForm.cs - Handles selection of limited places based on subscription
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace fse_project
{
    public partial class PlaceSelectionForm : Form
    {
        private List<string> allPlaces = new List<string>
        {
            "Gate 36", "Near the Black Stone (Hajar al-Aswad)", "Raudah",
            "Rukun al-Shami and Rukun al-Yamani", "The Multazam"
        };

        private string userEmail;
        private string subscriptionType;
        private int allowedPlaces;
        private int allowedSlots;
        private int allowedBookings;

        public string SelectedPlace { get; private set; }

        public PlaceSelectionForm(string email, string subType, int maxPlaces, int slots, int bookings)
        {
            InitializeComponent();

            userEmail = email;
            subscriptionType = subType;
            allowedPlaces = maxPlaces;
            allowedSlots = slots;
            allowedBookings = bookings;

            LoadPlaces();
        }

        private void LoadPlaces()
        {
            listBoxPlaces.Items.Clear();

            // Limit number of places based on subscription
            for (int i = 0; i < Math.Min(allowedPlaces, allPlaces.Count); i++)
            {
                listBoxPlaces.Items.Add(allPlaces[i]);
            }
        }

        private void listBoxPlaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPlaces.SelectedItem != null)
            {
                SelectedPlace = listBoxPlaces.SelectedItem.ToString();
                this.Hide();
                BookingForm bookingForm = new BookingForm(userEmail, SelectedPlace, allowedSlots, allowedBookings);
                bookingForm.Show();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Owner?.Show();
            this.Close();
        }


        private void label1_Click(object sender, EventArgs e) { }
    }
}
