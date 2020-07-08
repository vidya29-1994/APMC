namespace APMCWaterBill
{
    partial class Form1
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
            this.dpBillDate = new System.Windows.Forms.DateTimePicker();
            this.lblBillMonth = new System.Windows.Forms.Label();
            this.lblMarket = new System.Windows.Forms.Label();
            this.lblMr2 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dpBillDate
            // 
            this.dpBillDate.Location = new System.Drawing.Point(161, 20);
            this.dpBillDate.Name = "dpBillDate";
            this.dpBillDate.Size = new System.Drawing.Size(156, 20);
            this.dpBillDate.TabIndex = 0;
            // 
            // lblBillMonth
            // 
            this.lblBillMonth.AutoSize = true;
            this.lblBillMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillMonth.Location = new System.Drawing.Point(13, 20);
            this.lblBillMonth.Name = "lblBillMonth";
            this.lblBillMonth.Size = new System.Drawing.Size(79, 17);
            this.lblBillMonth.TabIndex = 1;
            this.lblBillMonth.Text = "Bill Month";
            // 
            // lblMarket
            // 
            this.lblMarket.AutoSize = true;
            this.lblMarket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarket.Location = new System.Drawing.Point(13, 73);
            this.lblMarket.Name = "lblMarket";
            this.lblMarket.Size = new System.Drawing.Size(72, 17);
            this.lblMarket.TabIndex = 2;
            this.lblMarket.Text = "Market...";
            // 
            // lblMr2
            // 
            this.lblMr2.AutoSize = true;
            this.lblMr2.Location = new System.Drawing.Point(158, 77);
            this.lblMr2.Name = "lblMr2";
            this.lblMr2.Size = new System.Drawing.Size(30, 13);
            this.lblMr2.TabIndex = 3;
            this.lblMr2.Text = "MR2";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGenerate.Location = new System.Drawing.Point(161, 128);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(96, 28);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblBillMonth);
            this.panel1.Controls.Add(this.btnGenerate);
            this.panel1.Controls.Add(this.dpBillDate);
            this.panel1.Controls.Add(this.lblMr2);
            this.panel1.Controls.Add(this.lblMarket);
            this.panel1.Location = new System.Drawing.Point(108, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 195);
            this.panel1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dpBillDate;
        private System.Windows.Forms.Label lblBillMonth;
        private System.Windows.Forms.Label lblMarket;
        private System.Windows.Forms.Label lblMr2;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Panel panel1;
    }
}

