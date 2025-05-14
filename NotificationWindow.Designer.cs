namespace fse_project
{
    partial class NotificationWindow
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lstNotifications;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lstNotifications = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstNotifications
            // 
            this.lstNotifications.BackColor = System.Drawing.Color.White;
            this.lstNotifications.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNotifications.FormattingEnabled = true;
            this.lstNotifications.ItemHeight = 31;
            this.lstNotifications.Location = new System.Drawing.Point(260, 103);
            this.lstNotifications.Name = "lstNotifications";
            this.lstNotifications.Size = new System.Drawing.Size(703, 407);
            this.lstNotifications.TabIndex = 0;
            // 
            // NotificationWindow
            // 
            this.BackgroundImage = global::fse_project.Properties.Resources.Untitled_Project;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1216, 604);
            this.Controls.Add(this.lstNotifications);
            this.Name = "NotificationWindow";
            this.Text = "Notifications";
            this.ResumeLayout(false);
        }
    }
}
