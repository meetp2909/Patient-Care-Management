using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientCareManagement.Droid.Model
{
     /// <summary>
    /// The Medication class represents a medication prescribed to a patient in the patient care management system.
    /// It includes information such as the medication ID, name, dosage, frequency, start and end dates, and 
    /// special instructions. This class is essential for tracking patient medication schedules and ensuring 
    /// proper adherence to prescribed treatments.
    /// </summary>
    internal class Medication
{
        
        public int MedicationID { get; set; }
    public string Name { get; set; }
    public string Dosage { get; set; }
    public string Frequency { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Instructions { get; set; }

}
}

