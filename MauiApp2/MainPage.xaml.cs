using System.Threading.Tasks;
using MauiApp1.models;

namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
     
        public MainPage()
        {

            InitializeComponent();
            

        }

        private async void LogIn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }

        private async void SignUp_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignupPage());
        }
    }

}
