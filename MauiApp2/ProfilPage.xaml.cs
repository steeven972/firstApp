using MauiApp1.models;
using MauiApp2.models;
using Microsoft.VisualBasic;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace MauiApp2;

public partial class ProfilPage : ContentPage
{
    public string name;
    public string email;
    public string password;
    public List<string> experiences = new List<string>();
    public List<string> formations = new List<string>();
    private Alternant user;
    public ProfilPage(string name, string email, string password)
	{

        this.name = name;
        this.email = email;
        this.password = password;
        experiences.Add("Experience 1");
        experiences.Add("Experience 2");
        formations.Add("Formation 1");
        formations.Add("Formation 2");
        Cv cv = new Cv(1, name, email, "123456789", "Tunis", experiences, formations);
        
        InitializeComponent();
        user = new Alternant(1, name, email, password, "profil_user.jpg");
        user.AddCv(cv);

        (string nameLabel, string emailLabel) = user.showUser();
        NameLabel.Text = nameLabel;
        EmailLabel.Text = emailLabel;
        imageProfil.Source = user.getImageUrl();
        
    }

    private async void postulate_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new OffresPage(user));
    }
}