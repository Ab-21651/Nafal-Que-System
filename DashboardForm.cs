// ✅ DashboardForm.cs - Handles subscription-aware navigation
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace fse_project
{
    public partial class DashboardForm : Form
    {
        public static List<string> Notifications = new List<string>();
        public static int notificationCount = 0;

        private string userEmail;
        private string subscriptionType;
        private int allowedPlaces;
        private int allowedSlots;
        private int allowedBookings;
        private Button buttonTasbeeh;

        private Button btnNotification;
        private Label lblBadge;

        public DashboardForm(string email, string subType, int places, int slots, int bookings)
        {
            InitializeComponent();
            userEmail = email;
            subscriptionType = subType;
            allowedPlaces = places;
            allowedSlots = slots;
            allowedBookings = bookings;
            InitializeNotificationButton();
            InitializeTasbeehButton();
        }

        private void InitializeTasbeehButton()
        {
            buttonTasbeeh = new Button
            {
                Size = new Size(200, 40), // adjust as per others
                Location = new Point(100, 308), // adjust to appear under existing buttons
                Text = "Tasbeeh",
                Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold), // same as others
                BackColor = Color.White,
                FlatStyle = FlatStyle.Standard
            };
            buttonTasbeeh.FlatAppearance.BorderSize = 1;

            buttonTasbeeh.Click += ButtonTasbeeh_Click;
            this.Controls.Add(buttonTasbeeh);
        }

        private void ButtonTasbeeh_Click(object sender, EventArgs e)
        {
            TasbeehCounterForm tasbeehForm = new TasbeehCounterForm(userEmail);
            tasbeehForm.Owner = this;
            tasbeehForm.FormClosed += (s, args) => this.Show();
            this.Hide();
            tasbeehForm.Show();
        }
        private void InitializeNotificationButton()
        {
            btnNotification = new Button
            {
                Size = new Size(50, 50),
                Location = new Point(20, 20),
                FlatStyle = FlatStyle.Flat,
                BackgroundImageLayout = ImageLayout.Stretch
            };

            try
            {
                btnNotification.BackgroundImage = Image.FromFile(@"A:\\Downloads\\STUDY\\FSE PROJECT\\ITERATION_2\\ITERATION_2\\Iteration_2_code_most_updated\\fse_project\\fse_project\\Resources\\bell.jpg");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);
            }

            btnNotification.Click += BtnNotification_Click;

            lblBadge = new Label
            {
                Text = notificationCount.ToString(),
                Size = new Size(20, 20),
                Location = new Point(35, 0),
                BackColor = Color.Red,
                ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 8, FontStyle.Bold),
                Visible = notificationCount > 0
            };

            this.Controls.Add(btnNotification);
            this.Controls.Add(lblBadge);
        }

        public static void AddNotification(string message)
        {
            Notifications.Add(message);
            notificationCount++;

            foreach (Form form in Application.OpenForms)
            {
                if (form is DashboardForm dashboard)
                {
                    dashboard.UpdateNotificationBadge();
                    break;
                }
            }
        }

        private void BtnNotification_Click(object sender, EventArgs e)
        {
            NotificationWindow notificationWindow = new NotificationWindow(Notifications);
            notificationWindow.Show();

            notificationWindow.FormClosed += (s, args) =>
            {
                Notifications.Clear();
                notificationCount = 0;
                UpdateNotificationBadge();
            };
        }

        public void UpdateNotificationBadge()
        {
            lblBadge.Visible = notificationCount > 0;
            lblBadge.Text = notificationCount.ToString();
        }

        private void buttonBook_Click(object sender, EventArgs e)
        {
            PlaceSelectionForm placeForm = new PlaceSelectionForm(userEmail, subscriptionType, allowedPlaces, allowedSlots, allowedBookings);
            placeForm.Owner = this;
            placeForm.FormClosed += (s, args) => this.Show(); // show Dashboard again
            this.Hide();
            placeForm.Show();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            CancelSlotForm cancelForm = new CancelSlotForm(userEmail, subscriptionType, allowedPlaces, allowedSlots, allowedBookings);
            cancelForm.Owner = this;
            cancelForm.FormClosed += (s, args) => this.Show(); // show Dashboard again
            this.Hide();
            cancelForm.Show();
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            ViewForm viewForm = new ViewForm(userEmail);
            viewForm.Owner = this;
            viewForm.FormClosed += (s, args) => this.Show();
            this.Hide();
            viewForm.Show();
        }


    }
}
