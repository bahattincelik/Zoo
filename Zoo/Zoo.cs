using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooManagement
{
    public class Zoo : IZooOperationen
    {
        private List<Tier> _tiere;

        public Zoo()
        {
            _tiere = new List<Tier>();
        }

        public void TierHinzufügen(Tier tier)
        {
            if (tier == null)
            {
                throw new ArgumentNullException(nameof(tier), "Tier darf nicht null sein");

                
            }

            _tiere.Add(tier);
            Console.WriteLine($"{tier.Name} wurde zum Zoo hinzufügt");
        }

        public void TierEntfernen(Tier tier)
        {
            if (tier == null) { throw new ArgumentNullException(nameof(tier), "Tier darf nicht null sein"); }

            _tiere.Remove(tier);
            Console.WriteLine($"{tier.Name} wurde aus dem Zoo entfernt.");
        }

        public void AlleTiereAnzeigen()
        {
            Console.WriteLine("Tiere im Zoo");
            foreach (Tier tier in _tiere)
            {
                string farbe = (tier as Säugetier)?.Fellfarbe ?? "Unbekannt";
                Console.WriteLine($"{tier.Name} hat die Farbe : {farbe}");
            }
        }

        public IEnumerable<int> GetTierAnzahl()
        {
            for (int i = 0; i <=_tiere.Count; i++)
            {
                yield return i;
            }
        }
    }
}
