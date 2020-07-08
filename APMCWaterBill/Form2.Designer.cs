namespace APMCWaterBill
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCalculation = new System.Windows.Forms.Button();
            this.btnReading = new System.Windows.Forms.Button();
            this.lblCalculation = new System.Windows.Forms.Label();
            this.lblFeedReading = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCalculation);
            this.panel1.Controls.Add(this.btnReading);
            this.panel1.Controls.Add(this.lblCalculation);
            this.panel1.Controls.Add(this.lblFeedReading);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(80, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 233);
            this.panel1.TabIndex = 0;
            // 
            // btnCalculation
            // 
            this.btnCalculation.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCalculation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCalculation.Location = new System.Drawing.Point(276, 139);
            this.btnCalculation.Name = "btnCalculation";
            this.btnCalculation.Size = new System.Drawing.Size(117, 46);
            this.btnCalculation.TabIndex = 4;
            this.btnCalculation.Text = "Bill Calculation";
            this.btnCalculation.UseVisualStyleBackColor = false;
            this.btnCalculation.Click += new System.EventHandler(this.btnCalculation_Click);
            // 
            // btnReading
            // 
            this.btnReading.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReading.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReading.Location = new System.Drawing.Point(276, 89);
            this.btnReading.Name = "btnReading";
            this.btnReading.Size = new System.Drawing.Size(117, 42);
            this.btnReading.TabIndex = 3;
            this.btnReading.Text = "Reading";
            this.btnReading.UseVisualStyleBackColor = false;
            this.btnReading.Click += new System.EventHandler(this.btnReading_Click);
            // 
            // lblCalculation
            // 
            this.lblCalculation.AutoSize = true;
            this.lblCalculation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculation.Location = new System.Drawing.Point(46, 153);
            this.lblCalculation.Name = "lblCalculation";
            this.lblCalculation.Size = new System.Drawing.Size(88, 15);
            this.lblCalculation.TabIndex = 2;
            this.lblCalculation.Text = "Bill Calculation";
            // 
            // lblFeedReading
            // 
            this.lblFeedReading.AutoSize = true;
            this.lblFeedReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedReading.Location = new System.Drawing.Point(45, 99);
            this.lblFeedReading.Name = "lblFeedReading";
            this.lblFeedReading.Size = new System.Drawing.Size(165, 15);
            this.lblFeedReading.TabIndex = 1;
            this.lblFeedReading.Text = "Feeding water meter reading";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Water Billing System";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculation;
        private System.Windows.Forms.Button btnReading;
        private System.Windows.Forms.Label lblCalculation;
        private System.Windows.Forms.Label lblFeedReading;
    }
}