using MauiApp1.models;
using MauiApp2.models;
namespace MauiApp1.models;



public class Alternant
{
    public int id;
    public string name;
    public string email;
    private string password;
    public Cv cvUser;
    public string image;
    public Alternant(int id, string name, string email, string password, string image)
    {
        this.id = id;
        this.name = name;
        this.email = email;
        this.password = password;
        this.image = image;
    }
    public (string, string) showUser()
    {
        return (this.name, this.email);
    }
    public string getImageUrl()
    {
        return this.image;
    }

    public void AddCv(Cv cv)
    {
        this.cvUser = cv;
    }
    public void RemoveCv(Cv cv)
    {
        this.cvUser = null;
    }
    public void postulate(Offre offre)
    {
        offre.postulatedAlternants.Add(this);
    }
}



