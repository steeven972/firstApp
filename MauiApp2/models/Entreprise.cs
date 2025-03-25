using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiApp1.models;
using MauiApp2.models;
namespace MauiApp2.models
{
    
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

