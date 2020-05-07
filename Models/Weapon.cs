using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace End_of_all_Hope.Models
{
    public class Weapon
    {
        public int WeaponID { get; set; }
        public int ItemID { get; set; }

        public int Multiplier { get; set; }

        public int Die { get; set; }

        public int Modifier { get; set; }
    }
}
