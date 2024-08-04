using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;
using Patient_Care_Management.Droid.ViewModel;
using PatientCareManagement.Droid.ViewModel;

namespace PatientCareManagement.Droid.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppointmentView : ContentPage
    {
        public AppointmentView()
        {
            InitializeComponent();
            BindingContext = new AppointmentViewModel();
        }
    }
}
