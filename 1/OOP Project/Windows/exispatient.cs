using System;
using System.Linq;
using System.Windows.Forms;
using OOP_Project.Models;

namespace OOP_Project.Windows
{
    public partial class exispatient : Form
    {
        private readonly BookingManager exisPatient;

        public exispatient()
        {
            InitializeComponent();

            exisPatient = new BookingManager();

            // Ensure the submit button actually invokes the handler (Designer did not wire it).
            btnSubmit.Click += btnSubmit_Click;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void exispatient_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var back = new rebook();
            back.Show();
            this.Hide();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (string.IsNullOrWhiteSpace(nameTextBox.Text) || string.IsNullOrWhiteSpace(phoneNumberTextBox.Text))
            {
                MessageBox.Show("Pls fill up the information.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (string.IsNullOrWhiteSpace(nameTextBox.Text))
                    nameTextBox.Focus();
                else
                    phoneNumberTextBox.Focus();
                return;
            }

            string name = nameTextBox.Text.Trim();
            string phone = phoneNumberTextBox.Text.Trim();
            if (!phone.All(char.IsDigit))
            {
                MessageBox.Show("Contact number can only contain digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                phoneNumberTextBox.Focus();
                return;
            }

            // Check DB for exact full-name match for existing patient
            BookingRecord? existingRecord = null;
            try
            {
                existingRecord = exisPatient.GetLatestBookingByName(name);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to look up existing patient data: " + ex.Message, "Lookup error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (existingRecord == null)
            {
                // Inform the user this is for existing patients only
                MessageBox.Show(
                    "Your name is not here. This form is for patients who already registered in New Patient.\nIf you're a new patient, please use the New Patient form to register first.",
                    "Name not found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                nameTextBox.Focus();
                return;
            }

            // Build appointment DateTime from date picker and time picker
            DateTime appointmentDate = appointmentDatePicker.Value.Date;
            TimeSpan appointmentTime = appointmentTimePicker.Value.TimeOfDay;
            DateTime appointmentDateTime = appointmentDate + appointmentTime;

            // Apply UI changes (medical screening + additional notes) to the record before opening confirm
            // Note: BookingRecord has init-only properties, so use `with` to create an updated instance.
            var updatedRecord = existingRecord with
            {
                CurrentMedication = yesRadioButton.Checked ? "Yes" : (noRadioButton.Checked ? "No" : existingRecord.CurrentMedication ?? string.Empty),
                AdditionalNotes = (additionalNotesTextBox.Text ?? string.Empty).Trim()
            };

            // Found existing patient — open confirmation form with DB values (updated with user's inputs)
            using (var confirm = new exisConfirm(name, phone, appointmentDateTime, updatedRecord))
            {
                // Hide current form while confirmation dialog is shown
                this.Hide();
                var result = confirm.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    // user confirmed - optionally call booking logic here
                    // exisPatient.InsertBooking(...) is handled inside exisConfirm on confirm
                }
                // close or show again depending on your flow; here we close the current form
                this.Close();
            }
        }

        private void appointmentDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void appointmentTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void phoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void yesRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void noRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void additionalNotesTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}