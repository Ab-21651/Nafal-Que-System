using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace fse_project
{
    public partial class NotificationWindow : Form
    {
        private List<string> notifications;

        public NotificationWindow(List<string> notifications)
        {
            InitializeComponent();
            this.notifications = notifications;
            DisplayNotifications();

            // Handle the window close event
            this.FormClosed += NotificationWindow_FormClosed;
        }

        // Display the notifications in the ListBox
        private void DisplayNotifications()
        {
            lstNotifications.Items.Clear();  // Clear any old items first
            lstNotifications.Items.AddRange(notifications.ToArray());  // Add the new notifications
        }

        // Clear notifications when the window is closed
        private void NotificationWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClearNotifications();  // Clear the notifications list and ListBox when the window is closed
        }

        // Method to clear the notifications
        private void ClearNotifications()
        {
            notifications.Clear();  // Clear the notifications list
            lstNotifications.Items.Clear();  // Clear the ListBox
        }
    }
}
