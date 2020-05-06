using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace End_of_all_Hope.Models
{
    public class ItemType
    {
        public int ItemID { get; set; }

        public ItemType Weapon { get; set; }

        public ItemType Consumable { get; set; }

        public ItemType Key { get; set; }
    }
}
