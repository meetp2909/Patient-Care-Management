using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using PatientCareManagement.Droid.Model;
using PatientCareManagement.Services;
using Xamarin.Forms;

namespace PatientCareManagement.ViewModels
{
    public class HealthRecordViewModel : BindableObject
    {
        private readonly IHealthRecordService _healthRecordService;

        public ObservableCollection<HealthRecord> HealthRecords { get; set; }
        public HealthRecord SelectedHealthRecord { get; set; }

        public ICommand LoadHealthRecordsCommand { get; }
        public ICommand AddHealthRecordCommand { get; }
        public ICommand UpdateHealthRecordCommand { get; }
        public ICommand DeleteHealthRecordCommand { get; }

        public HealthRecordViewModel(IHealthRecordService healthRecordService)
        {
            _healthRecordService = healthRecordService;
            HealthRecords = new ObservableCollection<HealthRecord>();
            LoadHealthRecordsCommand = new Command(async () => await LoadHealthRecordsAsync());
            AddHealthRecordCommand = new Command(async () => await AddHealthRecordAsync());
            UpdateHealthRecordCommand = new Command(async () => await UpdateHealthRecordAsync());
            DeleteHealthRecordCommand = new Command(async () => await DeleteHealthRecordAsync());
        }

        private async Task LoadHealthRecordsAsync()
        {
            var records = await _healthRecordService.GetHealthRecordsAsync();
            HealthRecords.Clear();
            foreach (var record in records)
            {
                HealthRecords.Add(record);
            }
        }

        private async Task AddHealthRecordAsync()
        {
            var newRecord = new HealthRecord
            {
                HealthRecordID = new Random().Next(1000, 9999),
                PatientID = 1, // This should be set properly
                VisitDate = DateTime.Now,
                Diagnosis = "Sample Diagnosis",
                Treatment = "Sample Treatment",
                Notes = "Sample Notes"
            };
            await _healthRecordService.AddHealthRecordAsync(newRecord);
            await LoadHealthRecordsAsync();
        }

        private async Task UpdateHealthRecordAsync()
        {
            if (SelectedHealthRecord != null)
            {
                await _healthRecordService.UpdateHealthRecordAsync(SelectedHealthRecord);
                await LoadHealthRecordsAsync();
            }
        }

        private async Task DeleteHealthRecordAsync()
        {
            if (SelectedHealthRecord != null)
            {
                await _healthRecordService.DeleteHealthRecordAsync(SelectedHealthRecord.HealthRecordID);
                await LoadHealthRecordsAsync();
            }
        }
    }
}
