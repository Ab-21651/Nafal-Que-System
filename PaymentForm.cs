using System;
using System.Windows.Forms;
using FirebaseAdmin.Auth;
using Google.Cloud.Firestore;

namespace fse_project
{
    public partial class PaymentForm : Form
    {
        private readonly string userEmail;
        private readonly string selectedSubscription;
        private readonly FirestoreDb db;
        private object userEmail1;
        private string selectedPackage;

        public PaymentForm(string email, string subscription)
        {
            InitializeComponent();
            userEmail = email;
            selectedSubscription = subscription;
            db = FirestoreDb.Create("naflqueue");

            this.Load += PaymentForm_Load;
        }



        public PaymentForm(object userEmail1, string selectedPackage)
        {
            this.userEmail1 = userEmail1;
            this.selectedPackage = selectedPackage;
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            comboBoxPaymentMethods.BackColor = System.Drawing.SystemColors.Info;
            comboBoxPaymentMethods.FormattingEnabled = true;
            comboBoxPaymentMethods.Items.AddRange(new object[]
            {
                "Visa", "MasterCard", "American Express", "PayPal", "Apple Pay", "Google Pay"
            });

            comboBoxPaymentMethods.SelectedIndex = 0; // default selection
        }

        private void buttonProceedToPayment_Click(object sender, EventArgs e)
        {
            if (comboBoxPaymentMethods.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a payment method.", "Error");
                return;
            }

            string selectedPaymentMethod = comboBoxPaymentMethods.SelectedItem.ToString();

            if (selectedPaymentMethod == "PayPal")
            {
                CompletePayment(selectedPaymentMethod);
            }
            else
            {
                string cardNumber = textBoxCardNumber.Text.Trim();
                string expiryDate = textBoxExpiryDate.Text.Trim();
                string cvv = textBoxCVV.Text.Trim();

                if (ValidateCardDetails(cardNumber, expiryDate, cvv))
                {
                    CompletePayment(selectedPaymentMethod);
                }
                else
                {
                    MessageBox.Show("Invalid card details.", "Error");
                }
            }
        }

        private bool ValidateCardDetails(string cardNumber, string expiryDate, string cvv)
        {
            return (cardNumber.Length == 16 && expiryDate.Length == 5 && expiryDate.Contains("/") && cvv.Length == 3);
        }

        private async void CompletePayment(string paymentMethod)
        {
            try
            {
                // Get user by email
                UserRecord user = await FirebaseAuth.DefaultInstance.GetUserByEmailAsync(userEmail);
                string userId = user.Uid;

                // Store subscription in Firestore
                DocumentReference docRef = db.Collection("users").Document(userId);
                await docRef.UpdateAsync("SubscriptionType", selectedSubscription);

                MessageBox.Show($"{paymentMethod} payment successful!\nSubscription activated: {selectedSubscription}", "Success");

               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Payment succeeded, but failed to store subscription:\n" + ex.Message, "Firestore Error");
            }
        }
    }
}
