using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooManagement
{
    public class Vogel : Tier
    {
        public double Flügelspannweite {  get; set; }

        public Vogel (string name, int alter, double flügelspannweite) : base (name, alter)
        {
            Flügelspannweite=flügelspannweite;
        }

        public void Fligen()
        {
            Console.WriteLine($"{Name} fliegt mit einer Flügelspannweite von {Flügelspannweite} Metern");
        }
    }
}
