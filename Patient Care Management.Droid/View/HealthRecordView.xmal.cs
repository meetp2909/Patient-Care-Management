using Java.Lang;
using Kotlin.Time;

using static System.Net.Mime.MediaTypeNames;

< ContentPage xmlns = "http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns: x = "http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns: local = "clr-namespace:PatientCareManagement.Views"
             x: Class = "PatientCareManagement.MainPage" >

    < StackLayout >
        < ListView ItemsSource = "{Binding HealthRecords}"
                  SelectedItem = "{Binding SelectedHealthRecord}" >
            < ListView.ItemTemplate >
                < DataTemplate >
                    < TextCell Text = "{Binding Diagnosis}" Detail = "{Binding VisitDate}" />
                </ DataTemplate >
            </ ListView.ItemTemplate >
        </ ListView >

        < Button Text = "Load Health Records" Command = "{Binding LoadHealthRecordsCommand}" />
        < Button Text = "Add Health Record" Command = "{Binding AddHealthRecordCommand}" />
        < Button Text = "Update Health Record" Command = "{Binding UpdateHealthRecordCommand}" />
        < Button Text = "Delete Health Record" Command = "{Binding DeleteHealthRecordCommand}" />
    </ StackLayout >

</ ContentPage >
