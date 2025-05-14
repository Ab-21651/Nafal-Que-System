namespace fse_project
{
    partial class BookingForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxSlots;
        private System.Windows.Forms.Button buttonBook;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelBookingStatus;


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingForm));
            this.listBoxSlots = new System.Windows.Forms.ListBox();
            this.buttonBook = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelBookingStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxSlots
            // 
            this.listBoxSlots.Font = new System.Drawing.Font("Arial", 10F);
            this.listBoxSlots.FormattingEnabled = true;
            this.listBoxSlots.ItemHeight = 16;
            this.listBoxSlots.Location = new System.Drawing.Point(84, 55);
            this.listBoxSlots.Name = "listBoxSlots";
            this.listBoxSlots.Size = new System.Drawing.Size(283, 260);
            this.listBoxSlots.TabIndex = 0;
            // 
            // buttonBook
            // 
            this.buttonBook.BackColor = System.Drawing.Color.LightGreen;
            this.buttonBook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonBook.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonBook.Location = new System.Drawing.Point(164, 343);
            this.buttonBook.Name = "buttonBook";
            this.buttonBook.Size = new System.Drawing.Size(121, 36);
            this.buttonBook.TabIndex = 1;
            this.buttonBook.Text = "📅 Book Slot";
            this.buttonBook.UseVisualStyleBackColor = true;
            this.buttonBook.Click += new System.EventHandler(this.buttonBook_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.LightGray;
            this.buttonBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonBack.Location = new System.Drawing.Point(23, 343);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(86, 32);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelBookingStatus
            // 
            this.labelBookingStatus.AutoSize = true;
            this.labelBookingStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelBookingStatus.Location = new System.Drawing.Point(30, 20);
            this.labelBookingStatus.Name = "labelBookingStatus";
            this.labelBookingStatus.Size = new System.Drawing.Size(101, 19);
            this.labelBookingStatus.TabIndex = 0;
            this.labelBookingStatus.Text = "Bookings: 0/0";
            // 
            // BookingForm
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(463, 400);
            this.Controls.Add(this.labelBookingStatus);
            this.Controls.Add(this.listBoxSlots);
            this.Controls.Add(this.buttonBook);
            this.Controls.Add(this.buttonBack);
            this.Name = "BookingForm";
            this.Text = "🕌 Nafal Prayer Booking System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
