using System;
using System.Windows.Forms;

namespace fse_project
{
    public partial class SubscriptionInfoForm : Form
    {
        public SubscriptionInfoForm()
        {
            InitializeComponent();
        }

        private void SubscriptionInfoForm_Load(object sender, EventArgs e)
        {
            labelInfo.Text =
                "Details about the subscription will be displayed here. This includes:\n\n" +
                "- Number of Areas Access\n" +
                "- Number of Slots Available\n" +
                "- Number of Bookings Allowed\n\n" +
                "Subscription Packages:\n" +
                "- Basic: 2 Areas, 6 Slots, 2 Bookings (70 SAR/Month)\n" +
                "- Standard: 4 Areas, 9 Slots, 4 Bookings (110 SAR/Month)\n" +
                "- Premium: 5 Areas, 15 Slots, 6 Bookings (150 SAR/Month)";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
