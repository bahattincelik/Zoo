using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooManagement
{
    public static class TierExtensions
    {
        public static bool IsAlt(this Tier tier)
        {
            return tier.Alter > 10;
        }
    }
}
