using MauiApp1.models;
using MauiApp2.models;
using Microsoft.VisualBasic;
using System.Xml;

namespace MauiApp2;

public partial class ProfilPage : ContentPage
{
    public string name;
    public string email;
    public string password;
    public List<string> experiences = new List<string>();
    public List<string> formations = new List<string>();
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
        User user = new User(1, name, email, password, cv, "profil_user.jpg");

        (string nameLabel, string emailLabel) = user.showUser();
        NameLabel.Text = nameLabel;
        EmailLabel.Text = emailLabel;
        imageProfil.Source = user.getImageUrl();
    }
}