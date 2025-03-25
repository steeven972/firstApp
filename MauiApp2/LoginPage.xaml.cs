using System.Threading.Tasks;

namespace MauiApp2;

public partial class LoginPage : ContentPage
{
	public (string name, string email, string password) getElement()
	{
		return (NameEntry.Text, EmailEntry.Text, PasswordEntry.Text);
    }
	public LoginPage()
	{
		InitializeComponent();
	}

    private async void LogInButton_Clicked(object sender, EventArgs e)
    {
		(string name, string email, string password) = getElement();
		await Navigation.PushAsync(new ProfilPage(name, email, password));
    }
}