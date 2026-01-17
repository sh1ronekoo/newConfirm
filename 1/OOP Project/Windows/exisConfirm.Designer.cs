namespace OOP_Project.Windows
{
    partial class exisConfirm
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
            label6 = new Label();
            label1 = new Label();
            label4 = new Label();
            label2 = new Label();
            label8 = new Label();
            label9 = new Label();
            btnCancel = new Button();
            btnConfirm = new Button();
            lblAppointmentDateTimeValue = new Label();
            lblPatientNameValue = new Label();
            lblPhoneValue = new Label();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(14, 134);
            label6.Name = "label6";
            label6.Size = new Size(184, 20);
            label6.TabIndex = 9;
            label6.Text = "👤 Personal Information";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 154);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 8;
            label1.Text = "Patient Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(14, 36);
            label4.Name = "label4";
            label4.Size = new Size(209, 20);
            label4.TabIndex = 11;
            label4.Text = "📅 Appointment Scheduling";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 56);
            label2.Name = "label2";
            label2.Size = new Size(202, 20);
            label2.TabIndex = 10;
            label2.Text = "Appointment Date and Time:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(14, 236);
            label8.Name = "label8";
            label8.Size = new Size(178, 20);
            label8.TabIndex = 13;
            label8.Text = "📞 Contact Information";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 261);
            label9.Name = "label9";
            label9.Size = new Size(53, 20);
            label9.TabIndex = 12;
            label9.Text = "Phone:";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(210, 25, 25);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(278, 337);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(95, 45);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(25, 118, 210);
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(379, 337);
            btnConfirm.Margin = new Padding(3, 4, 3, 4);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(95, 45);
            btnConfirm.TabIndex = 15;
            btnConfirm.Text = "CONFIRM";
            btnConfirm.UseVisualStyleBackColor = false;
            // 
            // lblAppointmentDateTimeValue
            // 
            lblAppointmentDateTimeValue.AutoSize = true;
            lblAppointmentDateTimeValue.Location = new Point(234, 56);
            lblAppointmentDateTimeValue.Name = "lblAppointmentDateTimeValue";
            lblAppointmentDateTimeValue.Size = new Size(140, 20);
            lblAppointmentDateTimeValue.TabIndex = 16;
            lblAppointmentDateTimeValue.Text = "01/17/2026 12:00 AM";
            // 
            // lblPatientNameValue
            // 
            lblPatientNameValue.AutoSize = true;
            lblPatientNameValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPatientNameValue.Location = new Point(140, 154);
            lblPatientNameValue.Name = "lblPatientNameValue";
            lblPatientNameValue.Size = new Size(101, 20);
            lblPatientNameValue.TabIndex = 17;
            lblPatientNameValue.Text = "PatientName";
            // 
            // lblPhoneValue
            // 
            lblPhoneValue.AutoSize = true;
            lblPhoneValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPhoneValue.Location = new Point(90, 261);
            lblPhoneValue.Name = "lblPhoneValue";
            lblPhoneValue.Size = new Size(78, 20);
            lblPhoneValue.TabIndex = 18;
            lblPhoneValue.Text = "000000000";
            // 
            // exisConfirm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(486, 395);
            Controls.Add(lblPhoneValue);
            Controls.Add(lblPatientNameValue);
            Controls.Add(lblAppointmentDateTimeValue);
            Controls.Add(btnConfirm);
            Controls.Add(btnCancel);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label1);
            Name = "exisConfirm";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label1;
        private Label label4;
        private Label label2;
        private Label label8;
        private Label label9;
        private Button btnCancel;
        private Button btnConfirm;
        private Label lblAppointmentDateTimeValue;
        private Label lblPatientNameValue;
        private Label lblPhoneValue;
    }
}