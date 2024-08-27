using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooManagement
{
    public class Katze: AbstrakesTier
    {
        public Katze(string name, int alter) : base(name, alter) { }

        public override void LautGeben()
        {
            Console.WriteLine($"{Name} sagt: Miau!");
        }
    }
}
