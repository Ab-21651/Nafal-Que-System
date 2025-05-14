namespace fse_project
{
    partial class SubscriptionForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelChooseSubscription;
        private System.Windows.Forms.Button buttonBasic;
        private System.Windows.Forms.Button buttonStandard;
        private System.Windows.Forms.Button buttonPremium;
        private System.Windows.Forms.Button infoButton;

        private void InitializeComponent()
        {
            this.labelChooseSubscription = new System.Windows.Forms.Label();
            this.buttonBasic = new System.Windows.Forms.Button();
            this.buttonStandard = new System.Windows.Forms.Button();
            this.buttonPremium = new System.Windows.Forms.Button();
            this.infoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelChooseSubscription
            // 
            this.labelChooseSubscription.AutoSize = true;
            this.labelChooseSubscription.Font = new System.Drawing.Font("Goudy Old Style", 17F, System.Drawing.FontStyle.Bold);
            this.labelChooseSubscription.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelChooseSubscription.Location = new System.Drawing.Point(84, 50);
            this.labelChooseSubscription.Name = "labelChooseSubscription";
            this.labelChooseSubscription.Size = new System.Drawing.Size(309, 27);
            this.labelChooseSubscription.TabIndex = 0;
            this.labelChooseSubscription.Text = "Choose Your Subscription Plan";
            // 
            // buttonBasic
            // 
            this.buttonBasic.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold);
            this.buttonBasic.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonBasic.Location = new System.Drawing.Point(163, 109);
            this.buttonBasic.Name = "buttonBasic";
            this.buttonBasic.Size = new System.Drawing.Size(124, 46);
            this.buttonBasic.TabIndex = 1;
            this.buttonBasic.Text = "Basic";
            this.buttonBasic.Click += new System.EventHandler(this.packageSelected_Click);
            // 
            // buttonStandard
            // 
            this.buttonStandard.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold);
            this.buttonStandard.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonStandard.Location = new System.Drawing.Point(163, 196);
            this.buttonStandard.Name = "buttonStandard";
            this.buttonStandard.Size = new System.Drawing.Size(124, 46);
            this.buttonStandard.TabIndex = 2;
            this.buttonStandard.Text = "Standard";
            this.buttonStandard.Click += new System.EventHandler(this.packageSelected_Click);
            // 
            // buttonPremium
            // 
            this.buttonPremium.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold);
            this.buttonPremium.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonPremium.Location = new System.Drawing.Point(163, 278);
            this.buttonPremium.Name = "buttonPremium";
            this.buttonPremium.Size = new System.Drawing.Size(124, 46);
            this.buttonPremium.TabIndex = 3;
            this.buttonPremium.Text = "Premium";
            this.buttonPremium.Click += new System.EventHandler(this.packageSelected_Click);
            // 
            // infoButton
            // 
            this.infoButton.Font = new System.Drawing.Font("Sitka Text", 7F, System.Drawing.FontStyle.Bold);
            this.infoButton.ForeColor = System.Drawing.Color.SaddleBrown;
            this.infoButton.Location = new System.Drawing.Point(403, 12);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(35, 24);
            this.infoButton.TabIndex = 4;
            this.infoButton.Text = "Info";
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // SubscriptionForm
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(450, 361);
            this.Controls.Add(this.labelChooseSubscription);
            this.Controls.Add(this.buttonBasic);
            this.Controls.Add(this.buttonStandard);
            this.Controls.Add(this.buttonPremium);
            this.Controls.Add(this.infoButton);
            this.Name = "SubscriptionForm";
            this.Text = "Select Subscription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
