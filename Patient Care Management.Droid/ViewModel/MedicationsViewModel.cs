using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using PatientCareManagement.Droid.Model;
using PatientCareManagement.Services;
using Xamarin.Forms;

namespace PatientCareManagement.ViewModel
{
    public class MedicationViewModel : BindableObject
    {
        private readonly MedicationService _medicationService;

        public ObservableCollection<Medication> Medications { get; set; }

        public Medication SelectedMedication { get; set; }

        public ICommand LoadMedicationsCommand { get; }
        public ICommand AddMedicationCommand { get; }
        public ICommand UpdateMedicationCommand { get; }
        public ICommand DeleteMedicationCommand { get; }

        public MedicationViewModel()
        {
            _medicationService = new MedicationService();
            Medications = new ObservableCollection<Medication>();
            LoadMedicationsCommand = new Command(async () => await LoadMedicationsAsync());
            AddMedicationCommand = new Command(async () => await AddMedicationAsync());
            UpdateMedicationCommand = new Command(async () => await UpdateMedicationAsync());
            DeleteMedicationCommand = new Command(async () => await DeleteMedicationAsync());
        }

        private async Task LoadMedicationsAsync()
        {
            var medications = await _medicationService.GetMedicationsAsync();
            Medications.Clear();
            foreach (var medication in medications)
            {
                Medications.Add(medication);
            }
        }

        private async Task AddMedicationAsync()
        {
            // Add logic for adding a new medication
            var newMedication = new Medication
            {
                MedicationID = Medications.Count + 1,
                Name = "New Medication",
                Dosage = "Dosage",
                Frequency = "Frequency",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(30),
                Instructions = "Instructions"
            };

            await _medicationService.AddMedicationAsync(newMedication);
            Medications.Add(newMedication);
        }

        private async Task UpdateMedicationAsync()
        {
            if (SelectedMedication != null)
            {
                await _medicationService.UpdateMedicationAsync(SelectedMedication);
                await LoadMedicationsAsync();
            }
        }

        private async Task DeleteMedicationAsync()
        {
            if (SelectedMedication != null)
            {
                await _medicationService.DeleteMedicationAsync(SelectedMedication.MedicationID);
                Medications.Remove(SelectedMedication);
            }
        }
    }
}
