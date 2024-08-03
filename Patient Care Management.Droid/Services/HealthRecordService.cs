using PatientCareManagement.Droid.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PatientCareManagement.Services
{
    public interface IHealthRecordService
    {
        Task<List<HealthRecord>> GetHealthRecordsAsync();
        Task<HealthRecord> GetHealthRecordByIdAsync(int id);
        Task AddHealthRecordAsync(HealthRecord record);
        Task UpdateHealthRecordAsync(HealthRecord record);
        Task DeleteHealthRecordAsync(int id);
    }

    public class HealthRecordService : IHealthRecordService
    {
        private readonly List<HealthRecord> _healthRecords = new List<HealthRecord>();

        public async Task<List<HealthRecord>> GetHealthRecordsAsync()
        {
            // Simulate async database access
            return await Task.FromResult(_healthRecords);
        }

        public async Task<HealthRecord> GetHealthRecordByIdAsync(int id)
        {
            var record = _healthRecords.FirstOrDefault(hr => hr.HealthRecordID == id);
            return await Task.FromResult(record);
        }

        public async Task AddHealthRecordAsync(HealthRecord record)
        {
            _healthRecords.Add(record);
            await Task.CompletedTask;
        }

        public async Task UpdateHealthRecordAsync(HealthRecord record)
        {
            var existingRecord = _healthRecords.FirstOrDefault(hr => hr.HealthRecordID == record.HealthRecordID);
            if (existingRecord != null)
            {
                _healthRecords.Remove(existingRecord);
                _healthRecords.Add(record);
            }
            await Task.CompletedTask;
        }

        public async Task DeleteHealthRecordAsync(int id)
        {
            var record = _healthRecords.FirstOrDefault(hr => hr.HealthRecordID == id);
            if (record != null)
            {
                _healthRecords.Remove(record);
            }
            await Task.CompletedTask;
        }
    }
}
