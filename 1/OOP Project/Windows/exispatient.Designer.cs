namespace OOP_Project.Windows
{
    partial class exispatient
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
            label1 = new Label();
            label6 = new Label();
            label3 = new Label();
            nameTextBox = new TextBox();
            label14 = new Label();
            label8 = new Label();
            phoneNumberTextBox = new TextBox();
            label11 = new Label();
            appointmentDatePicker = new DateTimePicker();
            appointmentTimePicker = new DateTimePicker();
            btnSubmit = new Button();
            button1 = new Button();
            yesRadioButton = new RadioButton();
            noRadioButton = new RadioButton();
            label16 = new Label();
            label20 = new Label();
            label9 = new Label();
            additionalNotesTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 51);
            label1.Name = "label1";
            label1.Size = new Size(323, 41);
            label1.TabIndex = 31;
            label1.Text = "WELCOME TO BACK!";
            label1.Click += label1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 197);
            label6.Name = "label6";
            label6.Size = new Size(106, 20);
            label6.TabIndex = 32;
            label6.Text = "👤 Full Name";
            label6.Click += label6_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Light", 9F);
            label3.Location = new Point(164, 273);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 33;
            // 
            // nameTextBox
            // 
            nameTextBox.BackColor = Color.FromArgb(248, 252, 252);
            nameTextBox.BorderStyle = BorderStyle.FixedSingle;
            nameTextBox.Location = new Point(12, 221);
            nameTextBox.Margin = new Padding(3, 4, 3, 4);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(360, 27);
            nameTextBox.TabIndex = 34;
            nameTextBox.TextChanged += nameTextBox_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(12, 270);
            label14.Name = "label14";
            label14.Size = new Size(178, 20);
            label14.TabIndex = 35;
            label14.Text = "📞 Contact Information";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(13, 291);
            label8.Name = "label8";
            label8.Size = new Size(105, 20);
            label8.TabIndex = 36;
            label8.Text = "Phone Number";
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.BackColor = Color.FromArgb(248, 252, 252);
            phoneNumberTextBox.BorderStyle = BorderStyle.FixedSingle;
            phoneNumberTextBox.Location = new Point(13, 315);
            phoneNumberTextBox.Margin = new Padding(3, 4, 3, 4);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(156, 27);
            phoneNumberTextBox.TabIndex = 37;
            phoneNumberTextBox.TextChanged += phoneNumberTextBox_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(12, 108);
            label11.Name = "label11";
            label11.Size = new Size(209, 20);
            label11.TabIndex = 38;
            label11.Text = "📅 Appointment Scheduling";
            // 
            // appointmentDatePicker
            // 
            appointmentDatePicker.CalendarMonthBackground = Color.FromArgb(248, 252, 252);
            appointmentDatePicker.Location = new Point(12, 132);
            appointmentDatePicker.Margin = new Padding(3, 4, 3, 4);
            appointmentDatePicker.Name = "appointmentDatePicker";
            appointmentDatePicker.Size = new Size(228, 27);
            appointmentDatePicker.TabIndex = 45;
            appointmentDatePicker.ValueChanged += appointmentDatePicker_ValueChanged;
            // 
            // appointmentTimePicker
            // 
            appointmentTimePicker.CalendarMonthBackground = Color.FromArgb(248, 252, 252);
            appointmentTimePicker.Format = DateTimePickerFormat.Time;
            appointmentTimePicker.Location = new Point(246, 132);
            appointmentTimePicker.Margin = new Padding(3, 4, 3, 4);
            appointmentTimePicker.Name = "appointmentTimePicker";
            appointmentTimePicker.ShowUpDown = true;
            appointmentTimePicker.Size = new Size(126, 27);
            appointmentTimePicker.TabIndex = 46;
            appointmentTimePicker.ValueChanged += appointmentTimePicker_ValueChanged;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(25, 118, 210);
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(225, 648);
            btnSubmit.Margin = new Padding(3, 4, 3, 4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(110, 44);
            btnSubmit.TabIndex = 47;
            btnSubmit.Text = "SUBMIT";
            btnSubmit.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(13, 12);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 51;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // yesRadioButton
            // 
            yesRadioButton.AutoSize = true;
            yesRadioButton.Location = new Point(38, 402);
            yesRadioButton.Margin = new Padding(3, 4, 3, 4);
            yesRadioButton.Name = "yesRadioButton";
            yesRadioButton.Size = new Size(51, 24);
            yesRadioButton.TabIndex = 52;
            yesRadioButton.TabStop = true;
            yesRadioButton.Text = "Yes";
            yesRadioButton.UseVisualStyleBackColor = true;
            yesRadioButton.CheckedChanged += yesRadioButton_CheckedChanged;
            // 
            // noRadioButton
            // 
            noRadioButton.AutoSize = true;
            noRadioButton.Location = new Point(38, 435);
            noRadioButton.Margin = new Padding(3, 4, 3, 4);
            noRadioButton.Name = "noRadioButton";
            noRadioButton.Size = new Size(50, 24);
            noRadioButton.TabIndex = 53;
            noRadioButton.TabStop = true;
            noRadioButton.Text = "No";
            noRadioButton.UseVisualStyleBackColor = true;
            noRadioButton.CheckedChanged += noRadioButton_CheckedChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(10, 358);
            label16.Name = "label16";
            label16.Size = new Size(161, 20);
            label16.TabIndex = 54;
            label16.Text = "💊 Medical Screening";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.Location = new Point(37, 378);
            label20.Name = "label20";
            label20.Size = new Size(216, 20);
            label20.TabIndex = 55;
            label20.Text = "Taking any medications currently?";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(10, 463);
            label9.Name = "label9";
            label9.Size = new Size(244, 20);
            label9.TabIndex = 57;
            label9.Text = "💬 Additional Notes / Symptoms";
            // 
            // additionalNotesTextBox
            // 
            additionalNotesTextBox.BackColor = Color.FromArgb(248, 252, 252);
            additionalNotesTextBox.BorderStyle = BorderStyle.FixedSingle;
            additionalNotesTextBox.Location = new Point(37, 487);
            additionalNotesTextBox.Margin = new Padding(3, 4, 3, 4);
            additionalNotesTextBox.Multiline = true;
            additionalNotesTextBox.Name = "additionalNotesTextBox";
            additionalNotesTextBox.Size = new Size(509, 153);
            additionalNotesTextBox.TabIndex = 56;
            additionalNotesTextBox.TextChanged += additionalNotesTextBox_TextChanged;
            // 
            // exispatient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(565, 754);
            Controls.Add(label9);
            Controls.Add(additionalNotesTextBox);
            Controls.Add(yesRadioButton);
            Controls.Add(noRadioButton);
            Controls.Add(label16);
            Controls.Add(label20);
            Controls.Add(button1);
            Controls.Add(btnSubmit);
            Controls.Add(appointmentTimePicker);
            Controls.Add(appointmentDatePicker);
            Controls.Add(label11);
            Controls.Add(phoneNumberTextBox);
            Controls.Add(label8);
            Controls.Add(label14);
            Controls.Add(nameTextBox);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label1);
            Name = "exispatient";
            StartPosition = FormStartPosition.CenterScreen;
            Load += exispatient_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label6;
        private Label label3;
        private TextBox nameTextBox;
        private Label label14;
        private Label label8;
        private TextBox phoneNumberTextBox;
        private Label label11;
        private DateTimePicker appointmentDatePicker;
        private DateTimePicker appointmentTimePicker;
        private Button btnSubmit;
        private Button button1;
        private RadioButton yesRadioButton;
        private RadioButton noRadioButton;
        private Label label16;
        private Label label20;
        private Label label9;
        private TextBox additionalNotesTextBox;
    }
}