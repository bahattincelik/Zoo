using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooManagement
{
    public interface IZooOperationen
    {
        void TierHinzufügen(Tier tier);
        void TierEntfernen(Tier tier);
        void AlleTiereAnzeigen();
        IEnumerable<int> GetTierAnzahl();
    }
}
