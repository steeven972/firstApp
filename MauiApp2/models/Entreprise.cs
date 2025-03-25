using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2.models
{
    class Offre
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Entreprise { get; set; }
        public string Date { get; set; }
        public string Location { get; set; }
        public string Type { get; set; }
        public string Salary { get; set; }
        public string Contract { get; set; }
        public string Experience { get; set; }
        public string Formation { get; set; }

        public Offre(string name, string description, string image, string entreprise, string date, string location, string type, string salary,
            string contract, string experience, string formation)
        {
            this.Name = name;
            this.Description = description;
            this.Image = image;
            this.Entreprise = entreprise;
            this.Date = date;
            this.Location = location;
            this.Type = type;
            this.Salary = salary;
            this.Contract = contract;
            this.Experience = experience;
            this.Formation = formation;

        }
        public (string, string) showOffre()
        {
            return (this.Name, this.Description);
        }
    }
    class Entreprise
    {
        public string Name { get; set; }
        public string Ceo { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public List<Offre> Offers { get; set; }

        public Entreprise(string name, string ceo, string address, string description, string image, List<Offre> offers)
        {
            this.Name = name;
            this.Ceo = ceo;
            this.Address = address;
            this.Description = description;
            this.Image = image;
            this.Offers = offers;
        }

        public (string, string) showEntreprise()
        {
            return (this.Name, this.Ceo);

        }

        public string getImageUrl()
        {
            return this.Image;
        }

        public void AddOffre(Offre offre)
        {
            this.Offers.Add(offre);
        }

        public void RemoveOffre(Offre offre)
        {
            this.Offers.Remove(offre);
        }

        public void showOffers()
        {
            foreach (Offre offre in this.Offers)
            {
                Console.WriteLine(offre.showOffre());
            }
        }

    }
}

