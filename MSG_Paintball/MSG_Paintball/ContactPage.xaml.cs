
namespace MSG_Paintball;

public partial class ContactPage : ContentPage
{
    public ContactPage()
    {
        InitializeComponent();
    }

    private async void OnSubmitClicked(object sender, EventArgs e)
    {
        string name = NameEntry.Text?.Trim() ?? "";
        string email = EmailEntry.Text?.Trim() ?? "";
        string subject = SubjectEntry.Text?.Trim() ?? "";

        if (string.IsNullOrWhiteSpace(name) ||
            string.IsNullOrWhiteSpace(email) ||
            string.IsNullOrWhiteSpace(subject))
        {
            await DisplayAlert(
                "Missing Information",
                "Please fill in your name, email and subject.",
                "OK");

            return;
        }

        if (!email.Contains('@'))
        {
            await DisplayAlert(
                "Invalid Email",
                "Please enter a valid email address.",
                "OK");

            return;
        }

        await DisplayAlert(
            "Thank You!",
            "Your message has been received.",
            "OK");

        NameEntry.Text = "";
        EmailEntry.Text = "";
        SubjectEntry.Text = "";
        NotesEditor.Text = "";
    }
}
