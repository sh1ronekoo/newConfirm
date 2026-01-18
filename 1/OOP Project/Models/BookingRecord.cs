namespace OOP_Project.Models
{
    // DTO used to carry booking/patient data from BookingManager to UI
    public sealed record BookingRecord
    {
        public string PatientName { get; init; } = string.Empty;
        public string Gender { get; init; } = string.Empty;
        public string Age { get; init; } = string.Empty;
        public string DateOfBirth { get; init; } = string.Empty;
        public string PhoneNumber { get; init; } = string.Empty;
        public string Email { get; init; } = string.Empty;
        public string Address { get; init; } = string.Empty;
        public string CurrentMedication { get; init; } = string.Empty;
        public string AdditionalNotes { get; init; } = string.Empty;
        public System.DateTime SubmissionDateTime { get; init; } = System.DateTime.MinValue;
        public System.DateTime AppointmentDateTime { get; init; } = System.DateTime.MinValue;
    }
}