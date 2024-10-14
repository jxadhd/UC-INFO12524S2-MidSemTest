namespace InterestCalculator
{
    partial class interestCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbxBreakdown = new System.Windows.Forms.ListBox();
            this.txtPeriods = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtClosing = new System.Windows.Forms.TextBox();
            this.lblOpening = new System.Windows.Forms.Label();
            this.lblPeriods = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblClosing = new System.Windows.Forms.Label();
            this.txtOpening = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(285, 175);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(134, 113);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(285, 294);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(134, 113);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(285, 413);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(134, 36);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit Application";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbxBreakdown
            // 
            this.lbxBreakdown.FormattingEnabled = true;
            this.lbxBreakdown.ItemHeight = 15;
            this.lbxBreakdown.Location = new System.Drawing.Point(12, 175);
            this.lbxBreakdown.Name = "lbxBreakdown";
            this.lbxBreakdown.Size = new System.Drawing.Size(267, 274);
            this.lbxBreakdown.TabIndex = 3;
            // 
            // txtPeriods
            // 
            this.txtPeriods.Location = new System.Drawing.Point(285, 48);
            this.txtPeriods.Name = "txtPeriods";
            this.txtPeriods.Size = new System.Drawing.Size(134, 23);
            this.txtPeriods.TabIndex = 4;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(285, 77);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(134, 23);
            this.txtRate.TabIndex = 5;
            // 
            // txtClosing
            // 
            this.txtClosing.Enabled = false;
            this.txtClosing.Location = new System.Drawing.Point(285, 141);
            this.txtClosing.Name = "txtClosing";
            this.txtClosing.Size = new System.Drawing.Size(134, 23);
            this.txtClosing.TabIndex = 6;
            // 
            // lblOpening
            // 
            this.lblOpening.AutoSize = true;
            this.lblOpening.Location = new System.Drawing.Point(12, 22);
            this.lblOpening.Name = "lblOpening";
            this.lblOpening.Size = new System.Drawing.Size(130, 15);
            this.lblOpening.TabIndex = 7;
            this.lblOpening.Text = "Enter Opening Balance:";
            // 
            // lblPeriods
            // 
            this.lblPeriods.AutoSize = true;
            this.lblPeriods.Location = new System.Drawing.Point(12, 51);
            this.lblPeriods.Name = "lblPeriods";
            this.lblPeriods.Size = new System.Drawing.Size(169, 15);
            this.lblPeriods.TabIndex = 8;
            this.lblPeriods.Text = "Enter Loan Lifetime in Months:";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(12, 80);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(105, 15);
            this.lblRate.TabIndex = 9;
            this.lblRate.Text = "Enter Interest Rate:";
            // 
            // lblClosing
            // 
            this.lblClosing.AutoSize = true;
            this.lblClosing.Location = new System.Drawing.Point(12, 149);
            this.lblClosing.Name = "lblClosing";
            this.lblClosing.Size = new System.Drawing.Size(94, 15);
            this.lblClosing.TabIndex = 10;
            this.lblClosing.Text = "Closing Balance:";
            // 
            // txtOpening
            // 
            this.txtOpening.Location = new System.Drawing.Point(285, 19);
            this.txtOpening.Name = "txtOpening";
            this.txtOpening.Size = new System.Drawing.Size(134, 23);
            this.txtOpening.TabIndex = 11;
            // 
            // interestCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 461);
            this.Controls.Add(this.txtOpening);
            this.Controls.Add(this.lblClosing);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblPeriods);
            this.Controls.Add(this.lblOpening);
            this.Controls.Add(this.txtClosing);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtPeriods);
            this.Controls.Add(this.lbxBreakdown);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Name = "interestCalculator";
            this.Text = "Interest Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
        private ListBox lbxBreakdown;
        private TextBox txtPeriods;
        private TextBox txtRate;
        private TextBox txtClosing;
        private Label lblOpening;
        private Label lblPeriods;
        private Label lblRate;
        private Label lblClosing;
        private TextBox txtOpening;
    }
}