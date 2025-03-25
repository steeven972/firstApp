using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2.models
{
    public class Cv
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

    }
}
