using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient Care Management.WinUI.Model
{
       /// <summary>
    /// The HealthRecord class represents a health record for a patient in the patient care management system.
    /// It includes details such as the health record ID, patient ID, visit date, diagnosis, treatment, and 
    /// any additional notes. This class is used to store and retrieve important medical information about 
    /// patient visits, aiding in comprehensive and continuous patient care.
    /// </summary>

    internal class HealthRecord
{
    public int HealthRecordID { get; set; }
    public int PatientID { get; set; }
    public DateTime VisitDate { get; set; }
    public string Diagnosis { get; set; }
    public string Treatment { get; set; }
    public string Notes { get; set; }

}
}
