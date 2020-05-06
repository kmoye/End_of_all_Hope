using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace End_of_all_Hope.Models
{
    public class ScreenItem
    {
        public int ScreenItemID { get; set; }

        public int ScreenID { get; set; }

        public int ItemID { get; set; }

        public string Description { get; set; }

        public string TakenDescription { get; set; }

        public string Action { get; set; }
    }
}
