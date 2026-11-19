namespace msg_MAUI2;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnHoursClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//HoursLocationsPage");
    }

    private async void OnLogoutClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//MSG_Login");
    }
}
