namespace fse_project
{
    partial class WelcomeForm
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Old Style", 17F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(112, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Nafal Queue!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(115, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "A Seamless Way to Manage Your Nafal Prayers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(115, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(8, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "&";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 5;
            // 
            // buttonContinue
            // 
            this.buttonContinue.BackColor = System.Drawing.Color.Beige;
            this.buttonContinue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonContinue.Location = new System.Drawing.Point(91, 392);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(284, 41);
            this.buttonContinue.TabIndex = 4;
            this.buttonContinue.Text = "Continue to Dashboard";
            this.buttonContinue.UseVisualStyleBackColor = false;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // WelcomeForm
            // 
            this.ClientSize = new System.Drawing.Size(968, 500);
            this.Controls.Add(this.buttonContinue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WelcomeForm";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.WelcomeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonContinue;
    }
}
