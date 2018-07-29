namespace WindowsApp_GovernmentAppWindows
{
    partial class EmployeeTaxForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblHrlyRate = new System.Windows.Forms.Label();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.txtBxHours = new System.Windows.Forms.TextBox();
            this.txtBxHrlyRate = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblGross = new System.Windows.Forms.Label();
            this.txtBxGross = new System.Windows.Forms.TextBox();
            this.lblFica = new System.Windows.Forms.Label();
            this.txtBxFica = new System.Windows.Forms.TextBox();
            this.lblFed = new System.Windows.Forms.Label();
            this.txtBxFed = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.txtBxState = new System.Windows.Forms.TextBox();
            this.lblHealth = new System.Windows.Forms.Label();
            this.txtBxHealth = new System.Windows.Forms.TextBox();
            this.lblNet = new System.Windows.Forms.Label();
            this.txtBxNet = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Indigo;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitle.Location = new System.Drawing.Point(194, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(307, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Tag = "Title";
            this.lblTitle.Text = "How Much Is the Government Robbing You? \r\n";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Indigo;
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblName.Location = new System.Drawing.Point(110, 46);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 22);
            this.lblName.TabIndex = 1;
            this.lblName.Tag = "Name label";
            this.lblName.Text = "Name:";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.BackColor = System.Drawing.Color.Indigo;
            this.lblHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHours.Location = new System.Drawing.Point(110, 78);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(109, 22);
            this.lblHours.TabIndex = 2;
            this.lblHours.Tag = "lblHours";
            this.lblHours.Text = "Hours Worked:";
            // 
            // lblHrlyRate
            // 
            this.lblHrlyRate.AutoSize = true;
            this.lblHrlyRate.BackColor = System.Drawing.Color.Indigo;
            this.lblHrlyRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHrlyRate.Location = new System.Drawing.Point(110, 119);
            this.lblHrlyRate.Name = "lblHrlyRate";
            this.lblHrlyRate.Size = new System.Drawing.Size(92, 22);
            this.lblHrlyRate.TabIndex = 3;
            this.lblHrlyRate.Tag = "lblHrlyRate";
            this.lblHrlyRate.Text = "Hourly Rate:";
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(182, 39);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(235, 27);
            this.txtBxName.TabIndex = 4;
            // 
            // txtBxHours
            // 
            this.txtBxHours.Location = new System.Drawing.Point(311, 71);
            this.txtBxHours.Name = "txtBxHours";
            this.txtBxHours.Size = new System.Drawing.Size(106, 27);
            this.txtBxHours.TabIndex = 5;
            // 
            // txtBxHrlyRate
            // 
            this.txtBxHrlyRate.Location = new System.Drawing.Point(311, 112);
            this.txtBxHrlyRate.Name = "txtBxHrlyRate";
            this.txtBxHrlyRate.Size = new System.Drawing.Size(106, 27);
            this.txtBxHrlyRate.TabIndex = 6;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Indigo;
            this.btnCalculate.Location = new System.Drawing.Point(66, 157);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(207, 49);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate Government Robbery\r\n\r\n";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Indigo;
            this.btnReset.Location = new System.Drawing.Point(295, 157);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(135, 29);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblGross
            // 
            this.lblGross.AutoSize = true;
            this.lblGross.BackColor = System.Drawing.Color.Indigo;
            this.lblGross.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGross.Location = new System.Drawing.Point(202, 222);
            this.lblGross.Name = "lblGross";
            this.lblGross.Size = new System.Drawing.Size(74, 22);
            this.lblGross.TabIndex = 9;
            this.lblGross.Text = "Gross Pay";
            // 
            // txtBxGross
            // 
            this.txtBxGross.Location = new System.Drawing.Point(317, 219);
            this.txtBxGross.Name = "txtBxGross";
            this.txtBxGross.Size = new System.Drawing.Size(100, 27);
            this.txtBxGross.TabIndex = 10;
            // 
            // lblFica
            // 
            this.lblFica.AutoSize = true;
            this.lblFica.BackColor = System.Drawing.Color.Indigo;
            this.lblFica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFica.Location = new System.Drawing.Point(202, 261);
            this.lblFica.Name = "lblFica";
            this.lblFica.Size = new System.Drawing.Size(68, 22);
            this.lblFica.TabIndex = 11;
            this.lblFica.Text = "FICA Tax\r\n";
            // 
            // txtBxFica
            // 
            this.txtBxFica.Location = new System.Drawing.Point(317, 261);
            this.txtBxFica.Name = "txtBxFica";
            this.txtBxFica.Size = new System.Drawing.Size(100, 27);
            this.txtBxFica.TabIndex = 12;
            // 
            // lblFed
            // 
            this.lblFed.AutoSize = true;
            this.lblFed.BackColor = System.Drawing.Color.Indigo;
            this.lblFed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFed.Location = new System.Drawing.Point(184, 307);
            this.lblFed.Name = "lblFed";
            this.lblFed.Size = new System.Drawing.Size(87, 22);
            this.lblFed.TabIndex = 13;
            this.lblFed.Text = "Federal Tax\r\n";
            // 
            // txtBxFed
            // 
            this.txtBxFed.Location = new System.Drawing.Point(317, 307);
            this.txtBxFed.Name = "txtBxFed";
            this.txtBxFed.Size = new System.Drawing.Size(100, 27);
            this.txtBxFed.TabIndex = 14;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.BackColor = System.Drawing.Color.Indigo;
            this.lblState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblState.Location = new System.Drawing.Point(201, 356);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(72, 22);
            this.lblState.TabIndex = 15;
            this.lblState.Text = "State Tax\r\n";
            // 
            // txtBxState
            // 
            this.txtBxState.Location = new System.Drawing.Point(317, 356);
            this.txtBxState.Name = "txtBxState";
            this.txtBxState.Size = new System.Drawing.Size(100, 27);
            this.txtBxState.TabIndex = 16;
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.BackColor = System.Drawing.Color.Indigo;
            this.lblHealth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHealth.Location = new System.Drawing.Point(191, 407);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(82, 22);
            this.lblHealth.TabIndex = 17;
            this.lblHealth.Text = "Health Tax\r\n";
            // 
            // txtBxHealth
            // 
            this.txtBxHealth.Location = new System.Drawing.Point(317, 407);
            this.txtBxHealth.Name = "txtBxHealth";
            this.txtBxHealth.Size = new System.Drawing.Size(100, 27);
            this.txtBxHealth.TabIndex = 18;
            // 
            // lblNet
            // 
            this.lblNet.AutoSize = true;
            this.lblNet.BackColor = System.Drawing.Color.Indigo;
            this.lblNet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNet.Location = new System.Drawing.Point(212, 449);
            this.lblNet.Name = "lblNet";
            this.lblNet.Size = new System.Drawing.Size(62, 22);
            this.lblNet.TabIndex = 19;
            this.lblNet.Text = "Net Pay\r\n";
            // 
            // txtBxNet
            // 
            this.txtBxNet.Location = new System.Drawing.Point(317, 446);
            this.txtBxNet.Name = "txtBxNet";
            this.txtBxNet.Size = new System.Drawing.Size(100, 27);
            this.txtBxNet.TabIndex = 20;
            // 
            // EmployeeTaxForm
            // 
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(630, 527);
            this.Controls.Add(this.txtBxNet);
            this.Controls.Add(this.lblNet);
            this.Controls.Add(this.txtBxHealth);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.txtBxState);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.txtBxFed);
            this.Controls.Add(this.lblFed);
            this.Controls.Add(this.txtBxFica);
            this.Controls.Add(this.lblFica);
            this.Controls.Add(this.txtBxGross);
            this.Controls.Add(this.lblGross);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtBxHrlyRate);
            this.Controls.Add(this.txtBxHours);
            this.Controls.Add(this.txtBxName);
            this.Controls.Add(this.lblHrlyRate);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LawnGreen;
            this.Name = "EmployeeTaxForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblHrlyRate;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.TextBox txtBxHours;
        private System.Windows.Forms.TextBox txtBxHrlyRate;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblGross;
        private System.Windows.Forms.TextBox txtBxGross;
        private System.Windows.Forms.Label lblFica;
        private System.Windows.Forms.TextBox txtBxFica;
        private System.Windows.Forms.Label lblFed;
        private System.Windows.Forms.TextBox txtBxFed;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtBxState;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.TextBox txtBxHealth;
        private System.Windows.Forms.Label lblNet;
        private System.Windows.Forms.TextBox txtBxNet;
    }
}

