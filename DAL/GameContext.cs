using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using End_of_all_Hope.Models;
using Microsoft.EntityFrameworkCore;

namespace End_of_all_Hope.DAL
{
	public class GameContext : DbContext
	{

		public GameContext(DbContextOptions<GameContext> options)
			: base(options)
		{ }

		public DbSet<User> Users { get; set; }
		public DbSet<Item> Items { get; set; }
		public DbSet<UserItem> UserItems { get; set; }
	}
}
