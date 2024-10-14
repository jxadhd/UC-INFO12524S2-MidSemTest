namespace DistanceCalc
{
    partial class Form1
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(137, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(208, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "How Fucking Far?";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(102, 79);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(128, 15);
            this.lblSpeed.TabIndex = 1;
            this.lblSpeed.Text = "Average Speed (km/h):";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(102, 108);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(126, 15);
            this.lblHours.TabIndex = 2;
            this.lblHours.Text = "Time Travelled (hours):";
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(246, 76);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(157, 23);
            this.txtSpeed.TabIndex = 3;
            this.txtSpeed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSpeed_KeyDown);
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(246, 105);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(157, 23);
            this.txtHours.TabIndex = 4;
            this.txtHours.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHours_KeyDown);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(8, 134);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(456, 23);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Tell me how far we\'ll go, baby!";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 15;
            this.lstOutput.Location = new System.Drawing.Point(8, 161);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(456, 184);
            this.lstOutput.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 358);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Label lblSpeed;
        private Label lblHours;
        private TextBox txtSpeed;
        private TextBox txtHours;
        private Button btnCalculate;
        private ListBox lstOutput;
    }
}