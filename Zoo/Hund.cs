using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooManagement
{
public class Hund : AbstrakesTier
    {
        public Hund (string name, int alter):base(name, alter) { }

        public override void LautGeben()
        {
            Console.WriteLine($"{Name} sagt: Wuff Wuff!");
        }
    }
}
