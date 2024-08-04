using PatientCareManagement.Droid.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PatientCareManagement.Droid.ViewModel
{
    public class PatientViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Patient> Patients { get; set; }

        public PatientViewModel()
        {
            Patients = new ObservableCollection<Patient>();
           
        }

        public async Task LoadPatients()
        {
           
        }

       
    }
}
