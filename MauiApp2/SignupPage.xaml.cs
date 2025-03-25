namespace MauiApp2;

public partial class SignupPage : ContentPage
{
	public (string name, string email, string password) getElements()
    {
        return (NameEntry.Text, EmailEntry.Text, PasswordEntry.Text);
    }
    public SignupPage()
	{
		InitializeComponent();
	}

    private async void SignUpButton_Clicked(object sender, EventArgs e)
    {
        (string name, string email, string password) = getElements();
        await Navigation.PushAsync(new ProfilPage(name, email, password));
    }
}