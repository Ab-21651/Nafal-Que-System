namespace fse_project
{
    partial class TasbeehCounterForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Button buttonIncrement;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelCount = new System.Windows.Forms.Label();
            this.buttonIncrement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCount
            // 
            this.labelCount.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.labelCount.Location = new System.Drawing.Point(9, 6);
            this.labelCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(270, 58);
            this.labelCount.TabIndex = 0;
            this.labelCount.Text = "0";
            this.labelCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonIncrement
            // 
            this.buttonIncrement.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.buttonIncrement.Location = new System.Drawing.Point(64, 135);
            this.buttonIncrement.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonIncrement.Name = "buttonIncrement";
            this.buttonIncrement.Size = new System.Drawing.Size(150, 39);
            this.buttonIncrement.TabIndex = 1;
            this.buttonIncrement.Text = "Tap to Count";
            this.buttonIncrement.UseVisualStyleBackColor = true;
            this.buttonIncrement.Click += new System.EventHandler(this.buttonIncrement_Click);
            // 
            // TasbeehCounterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 204);
            this.Controls.Add(this.buttonIncrement);
            this.Controls.Add(this.labelCount);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TasbeehCounterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tasbeeh Counter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TasbeehCounterForm_FormClosed);
            this.ResumeLayout(false);

        }
    }
}
