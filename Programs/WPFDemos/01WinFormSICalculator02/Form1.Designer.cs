namespace WindowsFormsApp1
{
    partial class InterestCalculatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.principalTextBox = new System.Windows.Forms.TextBox();
            this.rateLabel = new System.Windows.Forms.Label();
            this.periodTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.interestTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.calculateInterestButton = new System.Windows.Forms.Button();
            this.rateComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Principal Amout";
            // 
            // principalTextBox
            // 
            this.principalTextBox.Location = new System.Drawing.Point(206, 63);
            this.principalTextBox.Name = "principalTextBox";
            this.principalTextBox.Size = new System.Drawing.Size(334, 26);
            this.principalTextBox.TabIndex = 1;
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.Location = new System.Drawing.Point(59, 129);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(84, 20);
            this.rateLabel.TabIndex = 2;
            this.rateLabel.Text = "Rate (p.a.)";
            // 
            // periodTextBox
            // 
            this.periodTextBox.Location = new System.Drawing.Point(206, 192);
            this.periodTextBox.Name = "periodTextBox";
            this.periodTextBox.Size = new System.Drawing.Size(233, 26);
            this.periodTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Period (Months)";
            // 
            // interestTextBox
            // 
            this.interestTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.interestTextBox.Location = new System.Drawing.Point(206, 288);
            this.interestTextBox.Name = "interestTextBox";
            this.interestTextBox.ReadOnly = true;
            this.interestTextBox.Size = new System.Drawing.Size(233, 26);
            this.interestTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Interest";
            // 
            // amountTextBox
            // 
            this.amountTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.amountTextBox.Location = new System.Drawing.Point(206, 375);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.ReadOnly = true;
            this.amountTextBox.Size = new System.Drawing.Size(233, 26);
            this.amountTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Amount";
            // 
            // calculateInterestButton
            // 
            this.calculateInterestButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calculateInterestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateInterestButton.ForeColor = System.Drawing.Color.White;
            this.calculateInterestButton.Location = new System.Drawing.Point(206, 233);
            this.calculateInterestButton.Name = "calculateInterestButton";
            this.calculateInterestButton.Size = new System.Drawing.Size(233, 39);
            this.calculateInterestButton.TabIndex = 10;
            this.calculateInterestButton.Text = "Calculate Interest";
            this.calculateInterestButton.UseVisualStyleBackColor = false;
            this.calculateInterestButton.Click += new System.EventHandler(this.calculateInterestButton_Click);
            // 
            // rateComboBox
            // 
            this.rateComboBox.FormattingEnabled = true;
            this.rateComboBox.Items.AddRange(new object[] {
            "10",
            "11",
            "12"});
            this.rateComboBox.Location = new System.Drawing.Point(206, 129);
            this.rateComboBox.Name = "rateComboBox";
            this.rateComboBox.Size = new System.Drawing.Size(343, 28);
            this.rateComboBox.TabIndex = 11;
            // 
            // InterestCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rateComboBox);
            this.Controls.Add(this.calculateInterestButton);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.interestTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.periodTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rateLabel);
            this.Controls.Add(this.principalTextBox);
            this.Controls.Add(this.label1);
            this.Name = "InterestCalculatorForm";
            this.Text = "Interest Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox principalTextBox;
        private System.Windows.Forms.Label rateLabel;
        private System.Windows.Forms.TextBox periodTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox interestTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button calculateInterestButton;
        private System.Windows.Forms.ComboBox rateComboBox;
    }
}

