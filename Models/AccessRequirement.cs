using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace End_of_all_Hope.Models
{
    public class AccessRequirement
    {
        public int AccessRequirementID { get; set; }

        public int AccessPointID { get; set; }

        public int ItemID { get; set; }

        public string ClosedMessage { get; set; }

        public string OpenMessage { get; set; }



    }
}
