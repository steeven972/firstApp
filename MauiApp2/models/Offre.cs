
using MauiApp1.models;

namespace MauiApp2.models
{
   public class Offre
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Entreprise { get; set; }
        public string Date { get; set; }
        public string Location { get; set; }
        public string Sector { get; set; }
        public double Salary { get; set; }
        public string ContractType { get; set; }
        public string Experience { get; set; }
        public string Formation { get; set; }
        public List<Alternant> postulatedAlternants { get; set; }
        public Offre(string name, string description, string image, string entreprise, string date, string location, string sector, double salary,
            string contract, string experience, string formation)
        {
            this.Name = name;
            this.Description = description;
            this.Image = image;
            this.Entreprise = entreprise;
            this.Date = date;
            this.Location = location;
            this.Sector = sector;
            this.Salary = salary;
            this.ContractType = contract;
            this.Experience = experience;
            this.Formation = formation;


        }
        public (string, string) showOffre()
        {
            return (this.Name, this.Description);
        }
    }
}
