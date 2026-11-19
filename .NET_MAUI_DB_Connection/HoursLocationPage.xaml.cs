namespace msg_MAUI2;

public partial class HoursLocationsPage : ContentPage
{
    public HoursLocationsPage()
    {
        InitializeComponent();
    }

    private async void OnContactClicked(object sender, EventArgs e)
    {
        await Launcher.Default.OpenAsync("https://www.google.com/maps/search/?api=1&query=162+O%27Haire+Road+Middletown+NY+10941");
    }
}
