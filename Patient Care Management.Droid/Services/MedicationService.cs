using PatientCareManagement.Droid.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientCareManagement.Services
{
    public class MedicationService
    {
        private readonly List<Medication> _medications;

        public MedicationService()
        {
            // Initialize with some dummy data
            _medications = new List<Medication>
            {
                new Medication
                {
                    MedicationID = 1,
                    Name = "Medication A",
                    Dosage = "10 mg",
                    Frequency = "Once a day",
                    StartDate = DateTime.Now.AddDays(-10),
                    EndDate = DateTime.Now.AddDays(20),
                    Instructions = "Take with food"
                },
                new Medication
                {
                    MedicationID = 2,
                    Name = "Medication B",
                    Dosage = "20 mg",
                    Frequency = "Twice a day",
                    StartDate = DateTime.Now.AddDays(-5),
                    EndDate = DateTime.Now.AddDays(15),
                    Instructions = "Take before bed"
                }
            };
        }

        public async Task<List<Medication>> GetMedicationsAsync()
        {
            // Simulate an asynchronous operation
            await Task.Delay(500);
            return _medications;
        }

        public async Task AddMedicationAsync(Medication medication)
        {
            await Task.Delay(500);
            _medications.Add(medication);
        }

        public async Task UpdateMedicationAsync(Medication medication)
        {
            await Task.Delay(500);
            var existingMedication = _medications.FirstOrDefault(m => m.MedicationID == medication.MedicationID);
            if (existingMedication != null)
            {
                existingMedication.Name = medication.Name;
                existingMedication.Dosage = medication.Dosage;
                existingMedication.Frequency = medication.Frequency;
                existingMedication.StartDate = medication.StartDate;
                existingMedication.EndDate = medication.EndDate;
                existingMedication.Instructions = medication.Instructions;
            }
        }

        public async Task DeleteMedicationAsync(int medicationID)
        {
            await Task.Delay(500);
            var medication = _medications.FirstOrDefault(m => m.MedicationID == medicationID);
            if (medication != null)
            {
                _medications.Remove(medication);
            }
        }
    }
}
