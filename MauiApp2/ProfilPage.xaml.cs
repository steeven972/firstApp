using MauiApp1.models;
using Microsoft.VisualBasic;
using System.Xml;

namespace MauiApp2;

public partial class ProfilPage : ContentPage
{
    int count = 0;
    public List<string> experiences = new List<string>();
    public List<string> formation = new List<string>();
    public ProfilPage()
	{
		InitializeComponent();

        experiences.Add("Software Developer at Microsoft");
        experiences.Add("Software Developer at Google");
        formation.Add("Computer Science at Harvard University");
        formation.Add("Computer Science at MIT");
        Cv cv = new Cv(1, "Marie Clacks", "marie@gmail.com", "123456789", "1234 Elm Street", experiences, formation);
        User user = new User(462, "Marie Clacks", "marie@gmail.com", "password", cv, "woman_profil.jpg");
        (string name, string email) = user.showUser();

        NameLabel.Text = name;
        EmailLabel.Text = email;
        imageProfil.Source = user.getImageUrl();
    }
}