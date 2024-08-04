using PatientCareManagement.Droid.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PatientCareManagement.Droid.Service
{
    public class AppointmentService
    {
        private List<Appointment> appointments;

        public AppointmentService()
        {
            appointments = new List<Appointment>();
        }


        public Task<List<Appointment>> GetAppointmentsAsync()
        {
            
            return Task.FromResult(appointments);
        }

        public Task AddAppointmentAsync(Appointment appointment)
        {
            appointments.Add(appointment);
            return Task.CompletedTask;
        }


        public Task RemoveAppointmentAsync(Appointment appointment)
        {
            appointments.Remove(appointment);
            return Task.CompletedTask;
        }
    }
}
