using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace End_of_all_Hope.Models
{
	public class User
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public virtual List<Item> Items { get; set; }
	}
}
