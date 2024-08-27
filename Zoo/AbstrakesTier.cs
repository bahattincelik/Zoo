using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooManagement
{
    public abstract class AbstrakesTier:Tier
    {
        public string Name { get; set; }
        public int Alter {  get; set; }

        public AbstrakesTier(string name, int alter) : base(name, alter) 
        {
            if (string.IsNullOrEmpty(name))
            { 
                throw new ArgumentNullException(nameof(name), "Name darf nicht leer sein");

            }

            Name = name;
            Alter = alter;

        }

        public abstract void LautGeben();

        public void InfoAnzeigen()
        {
            Console.WriteLine($"Name: {Name}, Alter: {Alter}");
        }
    }
}
