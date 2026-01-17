namespace OOP_Project
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
            components = new System.ComponentModel.Container();
            bindingSource1 = new BindingSource(components);
            label3 = new Label();
            nameTextBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            ageTextBox = new TextBox();
            phoneNumberTextBox = new TextBox();
            label7 = new Label();
            emailTextBox = new TextBox();
            label8 = new Label();
            btnSubmit = new Button();
            dateTextBox = new TextBox();
            label12 = new Label();
            label13 = new Label();
            label1 = new Label();
            streetTextBox = new TextBox();
            label17 = new Label();
            cityTextBox = new TextBox();
            label18 = new Label();
            stateProvinceTextBox = new TextBox();
            label19 = new Label();
            postalZipTextBox = new TextBox();
            label21 = new Label();
            label20 = new Label();
            genderComboBox = new ComboBox();
            dateOfBirthTextBox = new TextBox();
            appointmentTimePicker = new DateTimePicker();
            label11 = new Label();
            appointmentDatePicker = new DateTimePicker();
            label6 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            noRadioButton = new RadioButton();
            yesRadioButton = new RadioButton();
            panel1 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            label9 = new Label();
            panel2 = new Panel();
            additionalNotesTextBox = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Light", 9F);
            label3.Location = new Point(41, 165);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 5;
            label3.Text = "Name";
            // 
            // nameTextBox
            // 
            nameTextBox.BackColor = Color.FromArgb(248, 252, 252);
            nameTextBox.BorderStyle = BorderStyle.FixedSingle;
            nameTextBox.Location = new Point(41, 189);
            nameTextBox.Margin = new Padding(3, 4, 3, 4);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(387, 27);
            nameTextBox.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Light", 9F);
            label4.Location = new Point(435, 165);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 7;
            label4.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Light", 9F);
            label5.Location = new Point(569, 165);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 10;
            label5.Text = "Age";
            // 
            // ageTextBox
            // 
            ageTextBox.BackColor = Color.FromArgb(248, 252, 252);
            ageTextBox.BorderStyle = BorderStyle.FixedSingle;
            ageTextBox.Location = new Point(569, 189);
            ageTextBox.Margin = new Padding(3, 4, 3, 4);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.Size = new Size(59, 27);
            ageTextBox.TabIndex = 2;
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.BackColor = Color.FromArgb(248, 252, 252);
            phoneNumberTextBox.BorderStyle = BorderStyle.FixedSingle;
            phoneNumberTextBox.Location = new Point(41, 363);
            phoneNumberTextBox.Margin = new Padding(3, 4, 3, 4);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(156, 27);
            phoneNumberTextBox.TabIndex = 4;
            phoneNumberTextBox.TextChanged += phoneNumberTextBox_TextChanged;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(206, 339);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 14;
            label7.Text = "E-mail";
            // 
            // emailTextBox
            // 
            emailTextBox.BackColor = Color.FromArgb(248, 252, 252);
            emailTextBox.BorderStyle = BorderStyle.FixedSingle;
            emailTextBox.Location = new Point(205, 363);
            emailTextBox.Margin = new Padding(3, 4, 3, 4);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(229, 27);
            emailTextBox.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(41, 339);
            label8.Name = "label8";
            label8.Size = new Size(105, 20);
            label8.TabIndex = 16;
            label8.Text = "Phone Number";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(25, 118, 210);
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(519, 919);
            btnSubmit.Margin = new Padding(3, 4, 3, 4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(110, 44);
            btnSubmit.TabIndex = 13;
            btnSubmit.Text = "SUBMIT";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // dateTextBox
            // 
            dateTextBox.BackColor = Color.FromArgb(220, 238, 243);
            dateTextBox.BorderStyle = BorderStyle.None;
            dateTextBox.Enabled = false;
            dateTextBox.Location = new Point(474, 12);
            dateTextBox.Margin = new Padding(3, 4, 3, 4);
            dateTextBox.Name = "dateTextBox";
            dateTextBox.Size = new Size(154, 20);
            dateTextBox.TabIndex = 19;
            dateTextBox.TextAlign = HorizontalAlignment.Center;
            dateTextBox.TextChanged += dateTextBox_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Light", 9F);
            label12.Location = new Point(41, 224);
            label12.Name = "label12";
            label12.Size = new Size(87, 20);
            label12.TabIndex = 23;
            label12.Text = "Date of Birth";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Light", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(41, 244);
            label13.Name = "label13";
            label13.Size = new Size(95, 19);
            label13.TabIndex = 24;
            label13.Text = "YYYY-MM-DD";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 12);
            label1.Name = "label1";
            label1.Size = new Size(316, 41);
            label1.TabIndex = 30;
            label1.Text = "WELCOME TO PRMS\r\n";
            label1.Click += label1_Click;
            // 
            // streetTextBox
            // 
            streetTextBox.BackColor = Color.FromArgb(248, 252, 252);
            streetTextBox.BorderStyle = BorderStyle.FixedSingle;
            streetTextBox.Location = new Point(41, 467);
            streetTextBox.Margin = new Padding(3, 4, 3, 4);
            streetTextBox.Name = "streetTextBox";
            streetTextBox.Size = new Size(416, 27);
            streetTextBox.TabIndex = 6;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Light", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(40, 445);
            label17.Name = "label17";
            label17.Size = new Size(94, 19);
            label17.TabIndex = 33;
            label17.Text = "Street Address";
            // 
            // cityTextBox
            // 
            cityTextBox.BackColor = Color.FromArgb(248, 252, 252);
            cityTextBox.BorderStyle = BorderStyle.FixedSingle;
            cityTextBox.Location = new Point(464, 467);
            cityTextBox.Margin = new Padding(3, 4, 3, 4);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(164, 27);
            cityTextBox.TabIndex = 7;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Light", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(464, 445);
            label18.Name = "label18";
            label18.Size = new Size(31, 19);
            label18.TabIndex = 35;
            label18.Text = "City";
            // 
            // stateProvinceTextBox
            // 
            stateProvinceTextBox.BackColor = Color.FromArgb(248, 252, 252);
            stateProvinceTextBox.BorderStyle = BorderStyle.FixedSingle;
            stateProvinceTextBox.Location = new Point(41, 523);
            stateProvinceTextBox.Margin = new Padding(3, 4, 3, 4);
            stateProvinceTextBox.Name = "stateProvinceTextBox";
            stateProvinceTextBox.Size = new Size(205, 27);
            stateProvinceTextBox.TabIndex = 8;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Light", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.Location = new Point(40, 501);
            label19.Name = "label19";
            label19.Size = new Size(101, 19);
            label19.TabIndex = 37;
            label19.Text = "State / Province";
            // 
            // postalZipTextBox
            // 
            postalZipTextBox.BackColor = Color.FromArgb(248, 252, 252);
            postalZipTextBox.BorderStyle = BorderStyle.FixedSingle;
            postalZipTextBox.Location = new Point(254, 523);
            postalZipTextBox.Margin = new Padding(3, 4, 3, 4);
            postalZipTextBox.Name = "postalZipTextBox";
            postalZipTextBox.Size = new Size(156, 27);
            postalZipTextBox.TabIndex = 9;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Light", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.Location = new Point(253, 501);
            label21.Name = "label21";
            label21.Size = new Size(106, 19);
            label21.TabIndex = 40;
            label21.Text = "Postal / zip code";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.Location = new Point(40, 595);
            label20.Name = "label20";
            label20.Size = new Size(216, 20);
            label20.TabIndex = 41;
            label20.Text = "Taking any medications currently?";
            // 
            // genderComboBox
            // 
            genderComboBox.BackColor = Color.FromArgb(248, 252, 252);
            genderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Location = new Point(435, 189);
            genderComboBox.Margin = new Padding(3, 4, 3, 4);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(126, 28);
            genderComboBox.TabIndex = 1;
            // 
            // dateOfBirthTextBox
            // 
            dateOfBirthTextBox.BackColor = Color.FromArgb(248, 252, 252);
            dateOfBirthTextBox.Location = new Point(41, 265);
            dateOfBirthTextBox.Margin = new Padding(3, 4, 3, 4);
            dateOfBirthTextBox.Name = "dateOfBirthTextBox";
            dateOfBirthTextBox.Size = new Size(114, 27);
            dateOfBirthTextBox.TabIndex = 3;
            dateOfBirthTextBox.TextChanged += dateOfBirthTextBox_TextChanged;
            // 
            // appointmentTimePicker
            // 
            appointmentTimePicker.CalendarMonthBackground = Color.FromArgb(248, 252, 252);
            appointmentTimePicker.Format = DateTimePickerFormat.Time;
            appointmentTimePicker.Location = new Point(277, 99);
            appointmentTimePicker.Margin = new Padding(3, 4, 3, 4);
            appointmentTimePicker.Name = "appointmentTimePicker";
            appointmentTimePicker.ShowUpDown = true;
            appointmentTimePicker.Size = new Size(98, 27);
            appointmentTimePicker.TabIndex = 43;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(14, 75);
            label11.Name = "label11";
            label11.Size = new Size(209, 20);
            label11.TabIndex = 18;
            label11.Text = "📅 Appointment Scheduling";
            // 
            // appointmentDatePicker
            // 
            appointmentDatePicker.CalendarMonthBackground = Color.FromArgb(248, 252, 252);
            appointmentDatePicker.Location = new Point(41, 99);
            appointmentDatePicker.Margin = new Padding(3, 4, 3, 4);
            appointmentDatePicker.Name = "appointmentDatePicker";
            appointmentDatePicker.Size = new Size(228, 27);
            appointmentDatePicker.TabIndex = 44;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(14, 145);
            label6.Name = "label6";
            label6.Size = new Size(184, 20);
            label6.TabIndex = 5;
            label6.Text = "👤 Personal Information";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(13, 317);
            label14.Name = "label14";
            label14.Size = new Size(178, 20);
            label14.TabIndex = 16;
            label14.Text = "📞 Contact Information";
            label14.Click += label14_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(14, 417);
            label15.Name = "label15";
            label15.Size = new Size(144, 20);
            label15.TabIndex = 17;
            label15.Text = "🏠 Address Details";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(13, 575);
            label16.Name = "label16";
            label16.Size = new Size(161, 20);
            label16.TabIndex = 41;
            label16.Text = "💊 Medical Screening";
            // 
            // noRadioButton
            // 
            noRadioButton.AutoSize = true;
            noRadioButton.Location = new Point(41, 652);
            noRadioButton.Margin = new Padding(3, 4, 3, 4);
            noRadioButton.Name = "noRadioButton";
            noRadioButton.Size = new Size(50, 24);
            noRadioButton.TabIndex = 11;
            noRadioButton.TabStop = true;
            noRadioButton.Text = "No";
            noRadioButton.UseVisualStyleBackColor = true;
            // 
            // yesRadioButton
            // 
            yesRadioButton.AutoSize = true;
            yesRadioButton.Location = new Point(41, 619);
            yesRadioButton.Margin = new Padding(3, 4, 3, 4);
            yesRadioButton.Name = "yesRadioButton";
            yesRadioButton.Size = new Size(51, 24);
            yesRadioButton.TabIndex = 10;
            yesRadioButton.TabStop = true;
            yesRadioButton.Text = "Yes";
            yesRadioButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(14, 140);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(615, 1);
            panel1.TabIndex = 49;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.ForeColor = Color.Black;
            panel3.Location = new Point(14, 412);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(615, 1);
            panel3.TabIndex = 49;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Silver;
            panel4.ForeColor = Color.Black;
            panel4.Location = new Point(13, 312);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(615, 1);
            panel4.TabIndex = 49;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Silver;
            panel5.ForeColor = Color.Black;
            panel5.Location = new Point(13, 569);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(615, 1);
            panel5.TabIndex = 49;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(14, 691);
            label9.Name = "label9";
            label9.Size = new Size(244, 20);
            label9.TabIndex = 41;
            label9.Text = "💬 Additional Notes / Symptoms";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.ForeColor = Color.Black;
            panel2.Location = new Point(14, 685);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(615, 1);
            panel2.TabIndex = 49;
            // 
            // additionalNotesTextBox
            // 
            additionalNotesTextBox.BackColor = Color.FromArgb(248, 252, 252);
            additionalNotesTextBox.BorderStyle = BorderStyle.FixedSingle;
            additionalNotesTextBox.Location = new Point(41, 715);
            additionalNotesTextBox.Margin = new Padding(3, 4, 3, 4);
            additionalNotesTextBox.Multiline = true;
            additionalNotesTextBox.Name = "additionalNotesTextBox";
            additionalNotesTextBox.Size = new Size(587, 153);
            additionalNotesTextBox.TabIndex = 12;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(509, 66);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 50;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(220, 238, 243);
            ClientSize = new Size(647, 979);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(yesRadioButton);
            Controls.Add(noRadioButton);
            Controls.Add(appointmentDatePicker);
            Controls.Add(appointmentTimePicker);
            Controls.Add(dateOfBirthTextBox);
            Controls.Add(label9);
            Controls.Add(genderComboBox);
            Controls.Add(label16);
            Controls.Add(label20);
            Controls.Add(label21);
            Controls.Add(postalZipTextBox);
            Controls.Add(label19);
            Controls.Add(additionalNotesTextBox);
            Controls.Add(stateProvinceTextBox);
            Controls.Add(label18);
            Controls.Add(cityTextBox);
            Controls.Add(label17);
            Controls.Add(streetTextBox);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(dateTextBox);
            Controls.Add(label11);
            Controls.Add(label15);
            Controls.Add(btnSubmit);
            Controls.Add(label14);
            Controls.Add(label8);
            Controls.Add(emailTextBox);
            Controls.Add(label7);
            Controls.Add(phoneNumberTextBox);
            Controls.Add(ageTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(nameTextBox);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Patient Records Management System";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bindingSource1;
        private Label label3;
        private TextBox nameTextBox;
        private Label label4;
        private Label label5;
        private TextBox ageTextBox;
        private TextBox phoneNumberTextBox;
        private Label label7;
        private TextBox emailTextBox;
        private Label label8;
        private Button btnSubmit;
        private TextBox dateTextBox;
        private Label label12;
        private Label label13;
        private Label label1;
        private TextBox streetTextBox;
        private Label label17;
        private TextBox cityTextBox;
        private Label label18;
        private TextBox stateProvinceTextBox;
        private Label label19;
        private TextBox postalZipTextBox;
        private Label label21;
        private Label label20;
        private ComboBox genderComboBox;
        private TextBox dateOfBirthTextBox;
        private DateTimePicker appointmentTimePicker;
        private Label label11;
        private DateTimePicker appointmentDatePicker;
        private Label label6;
        private Label label14;
        private Label label15;
        private Label label16;
        private RadioButton noRadioButton;
        private RadioButton yesRadioButton;
        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label9;
        private Panel panel2;
        private TextBox additionalNotesTextBox;
        private Button button1;
    }
}