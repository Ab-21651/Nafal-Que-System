namespace fse_project
{
    partial class PaymentForm
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPaymentMethods = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCardNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxExpiryDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCVV = new System.Windows.Forms.TextBox();
            this.buttonProceedToPayment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(23, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment Method\r\n";
            // 
            // comboBoxPaymentMethods
            // 
            this.comboBoxPaymentMethods.FormattingEnabled = true;
            this.comboBoxPaymentMethods.Location = new System.Drawing.Point(201, 47);
            this.comboBoxPaymentMethods.Name = "comboBoxPaymentMethods";
            this.comboBoxPaymentMethods.Size = new System.Drawing.Size(163, 21);
            this.comboBoxPaymentMethods.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(23, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Card Number (16-Dig)";
            // 
            // textBoxCardNumber
            // 
            this.textBoxCardNumber.Location = new System.Drawing.Point(201, 99);
            this.textBoxCardNumber.Name = "textBoxCardNumber";
            this.textBoxCardNumber.Size = new System.Drawing.Size(163, 20);
            this.textBoxCardNumber.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(23, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Expiry Date (5 Dig ,\"/\")";
            // 
            // textBoxExpiryDate
            // 
            this.textBoxExpiryDate.Location = new System.Drawing.Point(201, 146);
            this.textBoxExpiryDate.Name = "textBoxExpiryDate";
            this.textBoxExpiryDate.Size = new System.Drawing.Size(163, 20);
            this.textBoxExpiryDate.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(23, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "CVV (3 Dig)";
            // 
            // textBoxCVV
            // 
            this.textBoxCVV.Location = new System.Drawing.Point(201, 193);
            this.textBoxCVV.Name = "textBoxCVV";
            this.textBoxCVV.Size = new System.Drawing.Size(163, 20);
            this.textBoxCVV.TabIndex = 7;
            // 
            // buttonProceedToPayment
            // 
            this.buttonProceedToPayment.BackColor = System.Drawing.Color.Beige;
            this.buttonProceedToPayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonProceedToPayment.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold);
            this.buttonProceedToPayment.Location = new System.Drawing.Point(123, 252);
            this.buttonProceedToPayment.Name = "buttonProceedToPayment";
            this.buttonProceedToPayment.Size = new System.Drawing.Size(150, 40);
            this.buttonProceedToPayment.TabIndex = 8;
            this.buttonProceedToPayment.Text = "Proceed to Payment";
            this.buttonProceedToPayment.UseVisualStyleBackColor = false;
            this.buttonProceedToPayment.Click += new System.EventHandler(this.buttonProceedToPayment_Click);
            // 
            // PaymentForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 320);
            this.Controls.Add(this.buttonProceedToPayment);
            this.Controls.Add(this.textBoxCVV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxExpiryDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCardNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxPaymentMethods);
            this.Controls.Add(this.label1);
            this.Name = "PaymentForm";
            this.Text = "Payment Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPaymentMethods;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCardNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxExpiryDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCVV;
        private System.Windows.Forms.Button buttonProceedToPayment;
    }
}
