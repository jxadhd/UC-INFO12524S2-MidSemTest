namespace LoanQualifier
{
    partial class Form
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
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtYearsEmployed = new System.Windows.Forms.TextBox();
            this.btnCheckQual = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblJob = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(139, 12);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 23);
            this.txtSalary.TabIndex = 0;
            // 
            // txtYearsEmployed
            // 
            this.txtYearsEmployed.Location = new System.Drawing.Point(139, 41);
            this.txtYearsEmployed.Name = "txtYearsEmployed";
            this.txtYearsEmployed.Size = new System.Drawing.Size(100, 23);
            this.txtYearsEmployed.TabIndex = 1;
            // 
            // btnCheckQual
            // 
            this.btnCheckQual.Location = new System.Drawing.Point(22, 70);
            this.btnCheckQual.Name = "btnCheckQual";
            this.btnCheckQual.Size = new System.Drawing.Size(217, 23);
            this.btnCheckQual.TabIndex = 2;
            this.btnCheckQual.Text = "Do I Qualify?";
            this.btnCheckQual.UseVisualStyleBackColor = true;
            this.btnCheckQual.Click += new System.EventHandler(this.btnQualify_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(22, 99);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(217, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(22, 15);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(82, 15);
            this.lblSalary.TabIndex = 4;
            this.lblSalary.Text = "Annual Salary:";
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Location = new System.Drawing.Point(22, 44);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(111, 15);
            this.lblJob.TabIndex = 5;
            this.lblJob.Text = "Years at current job:";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 137);
            this.Controls.Add(this.lblJob);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCheckQual);
            this.Controls.Add(this.txtYearsEmployed);
            this.Controls.Add(this.txtSalary);
            this.Name = "Form";
            this.Text = "Loan Qualifier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtSalary;
        private TextBox txtYearsEmployed;
        private Button btnCheckQual;
        private Button btnExit;
        private Label lblSalary;
        private Label lblJob;
    }
}