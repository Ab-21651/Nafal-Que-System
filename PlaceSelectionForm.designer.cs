using System;

namespace fse_project
{
    partial class PlaceSelectionForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxPlaces;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Button buttonBack; // Back button

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
            this.listBoxPlaces = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxPlaces
            // 
            this.listBoxPlaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPlaces.FormattingEnabled = true;
            this.listBoxPlaces.ItemHeight = 32;
            this.listBoxPlaces.Location = new System.Drawing.Point(404, 117);
            this.listBoxPlaces.Name = "listBoxPlaces";
            this.listBoxPlaces.Size = new System.Drawing.Size(526, 356);
            this.listBoxPlaces.TabIndex = 0;
            this.listBoxPlaces.SelectedIndexChanged += new System.EventHandler(this.listBoxPlaces_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(500, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please Select a Place";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonSelect
            // 
            this.buttonSelect.BackColor = System.Drawing.Color.LightBlue;
            this.buttonSelect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonSelect.Location = new System.Drawing.Point(594, 505);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(160, 40);
            this.buttonSelect.TabIndex = 2;
            this.buttonSelect.Text = "Proceed to Booking";
            this.buttonSelect.UseVisualStyleBackColor = false;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.LightGray;
            this.buttonBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonBack.Location = new System.Drawing.Point(594, 566);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(160, 40);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "Back to Signup";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // PlaceSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::fse_project.Properties.Resources.Untitled_Project;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1277, 663);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxPlaces);
            this.Name = "PlaceSelectionForm";
            this.Text = "Select Place";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
