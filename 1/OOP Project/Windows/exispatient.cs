using System;
using System.Linq;
using System.Windows.Forms;

namespace OOP_Project.Windows
{
    public partial class exispatient : Form
    {
        private readonly BookingManager exisPatient;
        public exispatient()
        {
            InitializeComponent();

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

            string phone = phoneNumberTextBox.Text.Trim();
            if (!phone.All(char.IsDigit))
            {
                MessageBox.Show("Contact number can only contain digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                phoneNumberTextBox.Focus();
                return;
            }

            // Build appointment DateTime from date picker and time picker
            DateTime appointmentDate = appointmentDatePicker.Value.Date;
            TimeSpan appointmentTime = appointmentTimePicker.Value.TimeOfDay;
            DateTime appointmentDateTime = appointmentDate + appointmentTime;

            // All validation passed — open confirmation form with values
            using (var confirm = new exisConfirm(nameTextBox.Text.Trim(), phone, appointmentDateTime))
            {
                // Hide current form while confirmation dialog is shown
                this.Hide();
                var result = confirm.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    // user confirmed - optionally call booking logic here
                    // e.g., exisPatient?.CreateBooking(...);
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
    }
}