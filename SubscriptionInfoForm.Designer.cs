namespace fse_project
{
    partial class SubscriptionInfoForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonClose;

        private void InitializeComponent()
        {
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelInfo.Location = new System.Drawing.Point(20, 20);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(400, 200);
            this.labelInfo.TabIndex = 0;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(170, 230);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(100, 30);
            this.buttonClose.Text = "Close";
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // SubscriptionInfoForm
            // 
            this.ClientSize = new System.Drawing.Size(450, 280);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonClose);
            this.Name = "SubscriptionInfoForm";
            this.Text = "Subscription Details";
            this.Load += new System.EventHandler(this.SubscriptionInfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
