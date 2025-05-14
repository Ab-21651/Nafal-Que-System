namespace fse_project
{
    partial class CancelSlotForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxPlaces;
        private System.Windows.Forms.ListBox listBoxBookedSlots;
        private System.Windows.Forms.Button buttonCancelBooking;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label1;

        private void InitializeComponent()
        {
            this.listBoxPlaces = new System.Windows.Forms.ListBox();
            this.listBoxBookedSlots = new System.Windows.Forms.ListBox();
            this.buttonCancelBooking = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxPlaces
            // 
            this.listBoxPlaces.Font = new System.Drawing.Font("Arial", 12F);
            this.listBoxPlaces.FormattingEnabled = true;
            this.listBoxPlaces.ItemHeight = 18;
            this.listBoxPlaces.Location = new System.Drawing.Point(82, 89);
            this.listBoxPlaces.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxPlaces.Name = "listBoxPlaces";
            this.listBoxPlaces.Size = new System.Drawing.Size(280, 220);
            this.listBoxPlaces.TabIndex = 0;
            this.listBoxPlaces.SelectedIndexChanged += new System.EventHandler(this.listBoxPlaces_SelectedIndexChanged);
            // 
            // listBoxBookedSlots
            // 
            this.listBoxBookedSlots.Font = new System.Drawing.Font("Arial", 12F);
            this.listBoxBookedSlots.FormattingEnabled = true;
            this.listBoxBookedSlots.ItemHeight = 18;
            this.listBoxBookedSlots.Location = new System.Drawing.Point(510, 89);
            this.listBoxBookedSlots.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxBookedSlots.Name = "listBoxBookedSlots";
            this.listBoxBookedSlots.Size = new System.Drawing.Size(281, 220);
            this.listBoxBookedSlots.TabIndex = 1;
            this.listBoxBookedSlots.SelectedIndexChanged += new System.EventHandler(this.listBoxBookedSlots_SelectedIndexChanged);
            // 
            // buttonCancelBooking
            // 
            this.buttonCancelBooking.BackColor = System.Drawing.Color.LightCoral;
            this.buttonCancelBooking.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonCancelBooking.ForeColor = System.Drawing.Color.Maroon;
            this.buttonCancelBooking.Location = new System.Drawing.Point(609, 345);
            this.buttonCancelBooking.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancelBooking.Name = "buttonCancelBooking";
            this.buttonCancelBooking.Size = new System.Drawing.Size(98, 29);
            this.buttonCancelBooking.TabIndex = 2;
            this.buttonCancelBooking.Text = "❌ Cancel Booking";
            this.buttonCancelBooking.UseVisualStyleBackColor = true;
            this.buttonCancelBooking.Click += new System.EventHandler(this.buttonCancelBooking_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.LightGray;
            this.buttonBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonBack.Location = new System.Drawing.Point(35, 354);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(86, 29);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(333, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please Select a Place";
            // 
            // CancelSlotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::fse_project.Properties.Resources.Untitled_Project;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(851, 431);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonCancelBooking);
            this.Controls.Add(this.listBoxBookedSlots);
            this.Controls.Add(this.listBoxPlaces);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CancelSlotForm";
            this.Text = "Cancel Slot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
