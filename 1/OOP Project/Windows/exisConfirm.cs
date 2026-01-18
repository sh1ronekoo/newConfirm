using System;
using System.Windows.Forms;
using System.Globalization;
using OOP_Project.Models;

namespace OOP_Project.Windows
{
    public partial class exisConfirm : Form
    {
        private readonly BookingManager _bookingManager = new BookingManager();
        private readonly BookingRecord? _record;
        private readonly DateTime _appointmentDateTime;
        private readonly string _patientName;
        private readonly string _phone;

        public exisConfirm()
        {
            InitializeComponent();
        }

        // Keep existing signature but accept optional BookingRecord
        public exisConfirm(string patientName, string phone, DateTime appointmentDateTime, BookingRecord? record = null)
        {
            InitializeComponent();

            // store values for later (confirm click)
            _patientName = string.IsNullOrWhiteSpace(patientName) ? string.Empty : patientName;
            _phone = string.IsNullOrWhiteSpace(phone) ? string.Empty : phone;
            _appointmentDateTime = appointmentDateTime;
            _record = record;

            // Populate UI with provided values
            lblPatientNameValue.Text = string.IsNullOrWhiteSpace(_patientName) ? "(no name)" : _patientName;
            lblPhoneValue.Text = string.IsNullOrWhiteSpace(_phone) ? "(no phone)" : _phone;
            lblAppointmentDateTimeValue.Text = _appointmentDateTime.ToString("MM/dd/yyyy hh:mm tt");

            // Populate gender/age/dob/email/address if record is available
            if (_record != null)
            {
                lblGenderValue.Text = string.IsNullOrWhiteSpace(_record.Gender) ? "(no gender)" : _record.Gender;
                lblAgeValue.Text = string.IsNullOrWhiteSpace(_record.Age) ? "(no age)" : _record.Age;
                lblDateOfBirthValue.Text = string.IsNullOrWhiteSpace(_record.DateOfBirth) ? "(no dob)" : _record.DateOfBirth;

                lblEmailValue.Text = string.IsNullOrWhiteSpace(_record.Email) ? "(no email)" : _record.Email;
                lblAddressValue.Text = string.IsNullOrWhiteSpace(_record.Address) ? "(no address)" : _record.Address;

                // --- NEW: show medication and additional notes ---
                // `label15` is the static "Medication:" label in the designer; append the value so it displays.
                var med = string.IsNullOrWhiteSpace(_record.CurrentMedication) ? "(none)" : _record.CurrentMedication;
                label15.Text = "Medication: " + med;

                // `lblAdditionalNotes` is the multi-line area in the designer; set its Text.
                lblAdditionalNotes.Text = string.IsNullOrWhiteSpace(_record.AdditionalNotes) ? "(none)" : _record.AdditionalNotes;
            }
            else
            {
                // No DB record — clear optional fields
                lblGenderValue.Text = "";
                lblAgeValue.Text = "";
                lblDateOfBirthValue.Text = "";
                lblEmailValue.Text = "";
                lblAddressValue.Text = "";

                // Clear medication/notes when there's no record
                label15.Text = "Medication:";
                lblAdditionalNotes.Text = "";
            }
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
            // When user confirms, insert a booking record to DB (similar to FormConfirmBooking behavior)
            try
            {
                var submissionDateTime = DateTime.Now;

                // Use values from the record if available; fall back to empty strings
                string gender = _record?.Gender ?? string.Empty;
                string age = _record?.Age ?? string.Empty;
                string dateOfBirthRaw = _record?.DateOfBirth ?? string.Empty;
                string email = _record?.Email ?? string.Empty;
                string address = _record?.Address ?? string.Empty;
                string currentMedication = _record?.CurrentMedication ?? string.Empty;
                string additionalNotes = _record?.AdditionalNotes ?? string.Empty;

                // Normalize dateOfBirth into yyyy-MM-dd for MySQL DATE column
                string dateOfBirthForDb = string.Empty;
                if (!string.IsNullOrWhiteSpace(dateOfBirthRaw))
                {
                    // try several common formats
                    var formats = new[] { "MM/dd/yyyy", "M/d/yyyy", "yyyy-MM-dd", "yyyy/MM/dd" };
                    if (DateTime.TryParseExact(dateOfBirthRaw, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out var dobParsed)
                        || DateTime.TryParse(dateOfBirthRaw, CultureInfo.InvariantCulture, DateTimeStyles.None, out dobParsed))
                    {
                        dateOfBirthForDb = dobParsed.ToString("yyyy-MM-dd");
                    }
                    else
                    {
                        // if parsing fails, leave empty (or you can throw / inform user)
                        dateOfBirthForDb = string.Empty;
                    }
                }

                _bookingManager.InsertBooking(
                    _appointmentDateTime,
                    submissionDateTime,
                    _patientName,
                    gender,
                    age,
                    dateOfBirthForDb,
                    _phone,
                    email,
                    address,
                    currentMedication,
                    additionalNotes
                );

                MessageBox.Show("Appointment saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                // Keep the form open and show the error so user can retry or cancel
                MessageBox.Show("Failed to save appointment: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exisConfirm_Load(object sender, EventArgs e)
        {

        }
    }
}
