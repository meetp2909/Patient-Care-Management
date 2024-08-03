using PatientCareManagement.Droid.Model;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace PatientCareManagement.Droid.Services
{
    public class PatientService
    {
        private List<Patient> patients = new List<Patient>();

        public Task<List<Patient>> GetPatientsAsync()
        {
            // In a real application, this would be a call to a database or web API
            return Task.FromResult(patients);
        }

        public Task AddPatientAsync(Patient patient)
        {
            patients.Add(patient);
            return Task.CompletedTask;
        }

        public Task UpdatePatientAsync(Patient patient)
        {
            var existingPatient = patients.Find(p => p.PatientID == patient.PatientID);
            if (existingPatient != null)
            {
                existingPatient.Name = patient.Name;
                existingPatient.DateOfBirth = patient.DateOfBirth;
                existingPatient.Gender = patient.Gender;
                existingPatient.ContactInfo = patient.ContactInfo;
                existingPatient.MedicalHistory = patient.MedicalHistory;
            }
            return Task.CompletedTask;
        }

        public Task DeletePatientAsync(int patientID)
        {
            var patient = patients.Find(p => p.PatientID == patientID);
            if (patient != null)
            {
                patients.Remove(patient);
            }
            return Task.CompletedTask;
        }
    }
}
