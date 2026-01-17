using System;
using System.Windows.Forms;

namespace OOP_Project.Windows
{
    public partial class exisConfirm : Form
    {
        public exisConfirm()
        {
            InitializeComponent();
        }

        // Constructor that accepts the values from exispatient
        public exisConfirm(string patientName, string phone, DateTime appointmentDateTime)
        {
            InitializeComponent();
            // Populate UI with provided values
            lblPatientNameValue.Text = string.IsNullOrWhiteSpace(patientName) ? "(no name)" : patientName;
            lblPhoneValue.Text = string.IsNullOrWhiteSpace(phone) ? "(no phone)" : phone;
            lblAppointmentDateTimeValue.Text = appointmentDateTime.ToString("MM/dd/yyyy hh:mm tt");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close and return Cancel result to caller
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // TODO: perform any confirmation/save logic (e.g., call BookingManager)
            // For now just close and return OK
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
