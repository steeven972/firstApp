using MauiApp1.models;

namespace MauiApp1.models;


    
class User
{
    public int id;
    public string name;
    public string email;
    private string password;
    public Cv cvUser;
    public User(int id, string name, string email, string password, Cv cvUser)
    {
        this.id = id;
        this.name = name;
        this.email = email;
        this.password = password;
        this.cvUser = cvUser;
    }
}

class Cv
{
    public int id;
    public string name;
    public string email;
    public string phoneNumber;
    public string address;
    public List<string> experiences;
    public List<string> formation;

    public Cv(int id, string name, string email, string phoneNumber, string address, List<string> experiences, List<string> formation)
    {
        this.id = id;
        this.name = name;
        this.email = email;
        this.phoneNumber = phoneNumber;
        this.address = address;
        this.experiences = experiences;
        this.formation = formation;
    }

    public void AddExperience(string experience)
    {
        this.experiences.Add(experience);
    }
    public void AddFormation(string formation)
    {
        this.formation.Add(formation);
    }

};





