using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Project.Models;

namespace OOP_Project
{
    public class BookingManager : BookingBase
    {
        private readonly string connectionString =
            "Server=oop-prms-iqperia06-3946oop.e.aivencloud.com;" +
            "Port=19631;" +
            "Database=defaultdb;" +
            "User ID=avnadmin;" +
            "Password=AVNS_DC-Fjd1udeFkVwK429X;" +
            "SslMode=Required;";

        public void InsertBooking(DateTime appointmentDateTime, DateTime submissionDateTime, string patientName,
                                  string gender, string age, string dateOfBirth, string phoneNumber, string email,
                                  string address, string currentMedication, string additionalNotes)
        {
            using var con = new MySqlConnection(connectionString);
            using var cmd = new MySqlCommand(@" INSERT INTO oop_project.booking 
                                            (appointment_datetime, submission_datetime, patient_name, gender, age, date_of_birth, phone_number, email, address, current_medication, additional_notes, status)
                                            VALUES 
                                            (@appointment_datetime, @submission_datetime, @patientname, @gender, @age, @dateofbirth, @phonenumber, @email, @address, @current_medication, @additional_notes, @status)", con);

            cmd.Parameters.AddWithValue("@appointment_datetime", appointmentDateTime);
            cmd.Parameters.AddWithValue("@submission_datetime", submissionDateTime);
            cmd.Parameters.AddWithValue("@patientname", patientName);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@age", age);
            cmd.Parameters.AddWithValue("@dateofbirth", dateOfBirth);
            cmd.Parameters.AddWithValue("@phonenumber", phoneNumber);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@current_medication", currentMedication);
            cmd.Parameters.AddWithValue("@additional_notes", additionalNotes);
            cmd.Parameters.AddWithValue("@status", "Pending");

            con.Open();
            cmd.ExecuteNonQuery();
        }

        // New: return the most recent booking row for an exact patient name match (or null)
        public BookingRecord? GetLatestBookingByName(string patientName)
        {
            if (string.IsNullOrWhiteSpace(patientName))
                return null;

            using var con = new MySqlConnection(connectionString);
            using var cmd = new MySqlCommand(@"
                SELECT appointment_datetime, submission_datetime, patient_name, gender, age, date_of_birth, phone_number, email, address, current_medication, additional_notes
                FROM oop_project.booking
                WHERE patient_name = @patientName
                ORDER BY submission_datetime DESC
                LIMIT 1", con);

            cmd.Parameters.AddWithValue("@patientName", patientName.Trim());

            con.Open();
            using var reader = cmd.ExecuteReader();
            if (!reader.Read())
                return null;

            // Use GetValue + convert safely for general fields, and format date_of_birth when it's a DateTime
            object? dobObj = reader.IsDBNull(5) ? null : reader.GetValue(5);

            string dobString;
            if (dobObj == null)
                dobString = string.Empty;
            else if (dobObj is DateTime dt)
                dobString = dt.ToString("MM/dd/yyyy"); // change format as you prefer
            else
                dobString = Convert.ToString(dobObj) ?? string.Empty;

            var record = new BookingRecord
            {
                AppointmentDateTime = reader.IsDBNull(0) ? DateTime.MinValue : reader.GetDateTime(0),
                SubmissionDateTime = reader.IsDBNull(1) ? DateTime.MinValue : reader.GetDateTime(1),
                PatientName = reader.IsDBNull(2) ? string.Empty : Convert.ToString(reader.GetValue(2)) ?? string.Empty,
                Gender = reader.IsDBNull(3) ? string.Empty : Convert.ToString(reader.GetValue(3)) ?? string.Empty,
                Age = reader.IsDBNull(4) ? string.Empty : Convert.ToString(reader.GetValue(4)) ?? string.Empty,
                DateOfBirth = dobString,
                PhoneNumber = reader.IsDBNull(6) ? string.Empty : Convert.ToString(reader.GetValue(6)) ?? string.Empty,
                Email = reader.IsDBNull(7) ? string.Empty : Convert.ToString(reader.GetValue(7)) ?? string.Empty,
                Address = reader.IsDBNull(8) ? string.Empty : Convert.ToString(reader.GetValue(8)) ?? string.Empty,
                CurrentMedication = reader.IsDBNull(9) ? string.Empty : Convert.ToString(reader.GetValue(9)) ?? string.Empty,
                AdditionalNotes = reader.IsDBNull(10) ? string.Empty : Convert.ToString(reader.GetValue(10)) ?? string.Empty
            };

            return record;
        }
    }
}
