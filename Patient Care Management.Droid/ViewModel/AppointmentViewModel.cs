using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Patient_Care_Management.Droid.Services;
using PatientCareManagement.Droid.Model;
using PatientCareManagement.Droid.Service;

namespace PatientCareManagement.Droid.ViewModel
{
    public class AppointmentViewModel : INotifyPropertyChanged
    {
        private readonly AppointmentService _appointmentService;

        public ObservableCollection<Appointment> Appointments { get; set; }
        public ICommand LoadAppointmentsCommand { get; }
        public ICommand AddAppointmentCommand { get; }
        public ICommand RemoveAppointmentCommand { get; }

        public AppointmentViewModel()
        {
            _appointmentService = new AppointmentService();
            Appointments = new ObservableCollection<Appointment>();
            LoadAppointmentsCommand = new Command(async () => await LoadAppointments());
            AddAppointmentCommand = new Command<Appointment>(async (appointment) => await AddAppointment(appointment));
            RemoveAppointmentCommand = new Command<Appointment>(async (appointment) => await RemoveAppointment(appointment));
        }

        public async Task LoadAppointments()
        {
            var appointments = await _appointmentService.GetAppointmentsAsync();
            Appointments.Clear();
            foreach (var appointment in appointments)
            {
                Appointments.Add(appointment);
            }
        }

        public async Task AddAppointment(Appointment appointment)
        {
            await _appointmentService.AddAppointmentAsync(appointment);
            await LoadAppointments(); 
        }

        public async Task RemoveAppointment(Appointment appointment)
        {
            await _appointmentService.RemoveAppointmentAsync(appointment);
            await LoadAppointments(); 
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
