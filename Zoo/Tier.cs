using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Tier
    {
        public string Name { get; private set; }
        public int Alter {  get; set; }
        public string Description { get; set; }


        public Tier(string name, int alter) 
        {
            if(string.IsNullOrEmpty(name)) throw new ArgumentNullException(nameof(name), "Name darf nicht leer sein");
            
            Name = name;
            Alter = alter;
        
        
        }

        public void SetName(string neuerName)
        {
            Name = neuerName ?? throw new ArgumentNullException(nameof(neuerName), "Name darf nicht leer sein");
        }

        public void InfoAnzeigen()
        {
            string beschreibung = Description ?? "Keine Beschreibung verfügbar";
            Console.WriteLine($"Name: {Name}, Alter: {Alter}, Beschreibung: {beschreibung}");
        }
    }
}
