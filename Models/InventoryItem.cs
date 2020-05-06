using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace End_of_all_Hope.Models
{
    public class InventoryItem
    {
        public int UserID { get; set; }

        public int ItemID { get; set; }

        public int ScreenItemID { get; set; }

        public int Quantity { get; set; }
    }
}
