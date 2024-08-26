using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Säugetier : Tier
    {
        public string Fellfarbe {  get; set; }
        public event Action AufMilchGeben;

        public Säugetier(string name, int alter, string fellfarbe) : base (name, alter)
        
        { 
            Fellfarbe = fellfarbe ?? throw new ArgumentNullException (nameof (fellfarbe), "Fellfarbe darf sein nicht leer sein");
        }

        public void MilchGeben()
        {
            Console.WriteLine($"{Name} gibt Milch");
            AufMilchGeben?.Invoke();
        }
    }
}
