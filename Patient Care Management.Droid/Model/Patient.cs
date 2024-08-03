using System;

namespace PatientCareManagement.Droid.Model
{
    /// <summary>
    /// Represents a patient in the patient care management system.
    /// This class includes fields for the patient ID, name, date of birth, gender,
    /// contact information, and medical history.
    /// </summary>
    internal class Patient
    {
        public int PatientID { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string ContactInfo { get; set; }
        public string MedicalHistory { get; set; }
    }
}
