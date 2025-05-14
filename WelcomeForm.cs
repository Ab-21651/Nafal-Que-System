using System.Windows.Forms;
using System;

namespace fse_project
{
    public partial class WelcomeForm : Form
    {
        private string userEmail;

        public WelcomeForm(string email)
        {
            InitializeComponent();
            userEmail = email;
        }


        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            // Welcome message and features
            label1.Text = "Welcome to Nafal Queue!";
            label2.Text = "A Seamless Way to Manage Your Nafal Prayers";

            label3.Text = "We're thrilled to have you onboard. Nafal Queue is designed with you in mind\n " +
                          "a platform that helps you manage your Nafal prayers with ease and convenience.\n " +
                          "Whether you're looking to book a slot, cancel an existing booking, or stay informed, we've got you covered every step of the way.\n\n" +

                          "Why Nafal Queue?\n" +
                          "• Book at Your Convenience.\n" +
                          "• Effortless Slot Management.\n" +
                          "• Always Stay Informed.\n\n" +

                          "A Smarter Way to Pray\n" +
                          "At Nafal Queue, we believe in simplifying your life.\n " +
                          "We bring you the power of technology to help you focus on what matters most.\n";


            buttonContinue.Text = "Continue ";
        }

        // Button to continue to the main page or dashboard
        private void buttonContinue_Click(object sender, EventArgs e)
        {
            SubscriptionForm subForm = new SubscriptionForm(userEmail);
            subForm.Show();
            this.Hide();

        }
    }
}
