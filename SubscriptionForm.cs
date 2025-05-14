using System;
using System.Windows.Forms;

namespace fse_project
{
    public partial class SubscriptionForm : Form
    {
        private string userEmail;


        public SubscriptionForm(string email)
        {
            InitializeComponent();
            userEmail = email;
        }


        private void infoButton_Click(object sender, EventArgs e)
        {
            SubscriptionInfoForm infoForm = new SubscriptionInfoForm();
            infoForm.ShowDialog();
        }

        private void packageSelected_Click(object sender, EventArgs e)
        {
            Button selectedButton = sender as Button;
            string selectedPackage = selectedButton.Text;
            MessageBox.Show($"You selected the {selectedPackage} package");

            PaymentForm paymentForm = new PaymentForm(userEmail, selectedPackage);
            paymentForm.Show();
            this.Hide();



        }
    }
}
