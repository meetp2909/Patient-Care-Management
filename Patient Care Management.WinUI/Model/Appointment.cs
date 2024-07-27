using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient Care Management.WinUI.Model
{
      /// <summary>
    /// Represents an appointment in the patient care management system.
    /// This class includes fields for the appointment ID, patient ID, provider ID,
    /// date, time, and purpose of the appointment.
    /// PatientID associates the appointment with a specific patient.
    /// ProviderID links the appointment to a healthcare provider.
    /// Purpose describes the reason or goal of the appointment.
    /// </summary>
    internal class Appointment
{
    
        public int AppointmentID { get; set; }
        public int PatientID { get; set; }
        public int ProviderID { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string Purpose { get; set; }
    }
}

