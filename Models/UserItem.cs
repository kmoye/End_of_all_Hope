using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace End_of_all_Hope.Models
{
	public class UserItem
	{
		[Key]
		public int UserItemID { get; set; }
		public int UserID { get; set; }
		public int ItemID { get; set; }
	}
}
