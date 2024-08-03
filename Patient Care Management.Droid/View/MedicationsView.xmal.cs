using Java.Lang;
using Kotlin.Time;
using PatientCareManagement.ViewModel;
using static Android.Icu.Text.CaseMap;

using static System.Net.Mime.MediaTypeNames;

<? xml version = "1.0" encoding = "utf-8" ?>
< ContentPage xmlns = "http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns: x = "http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns: vm = "clr-namespace:PatientCareManagement.ViewModel"
             x: Class = "PatientCareManagement.View.MedicationPage"
             Title = "Medications" >

    < ContentPage.BindingContext >
        < vm:MedicationViewModel />
    </ ContentPage.BindingContext >

    < StackLayout >
        < ListView ItemsSource = "{Binding Medications}"
                  SelectedItem = "{Binding SelectedMedication}" >
            < ListView.ItemTemplate >
                < DataTemplate >
                    < TextCell Text = "{Binding Name}" Detail = "{Binding Dosage}" />
                </ DataTemplate >
            </ ListView.ItemTemplate >
        </ ListView >


        < Button Text = "Load Medications" Command = "{Binding LoadMedicationsCommand}" />
        < Button Text = "Add Medication" Command = "{Binding AddMedicationCommand}" />
        < Button Text = "Update Medication" Command = "{Binding UpdateMedicationCommand}" />
        < Button Text = "Delete Medication" Command = "{Binding DeleteMedicationCommand}" />
    </ StackLayout >
</ ContentPage >
