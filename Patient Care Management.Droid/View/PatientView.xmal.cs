using System;
using Microsoft.Maui.Controls; // Update this line
using Microsoft.Maui.Controls.Xaml; // Update this line

namespace PatientCareManagement.Droid.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PatientView : ContentPage
    {
        public PatientView()
        {
            InitializeComponent();
            var viewModel = (PatientViewModel)BindingContext;
            viewModel.LoadPatients().ConfigureAwait(false);
        }
    }
}
