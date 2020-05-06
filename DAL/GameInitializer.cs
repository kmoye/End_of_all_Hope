using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using End_of_all_Hope.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace End_of_all_Hope.DAL
{
	public class GameInitializer
	{
		public static void Seed(IServiceProvider serviceProvider)
		{

			using (var context = new GameContext(serviceProvider.GetRequiredService<DbContextOptions<GameContext>>()))
			{
				//context.Database.EnsureDeleted();
				//context.Database.EnsureCreated();
				//context.Database.Migrate();

				var users = new List<User>
			{
				new User{ Id=1, Name="Ulrich von Liechtenstein" },
				new User{ Id=2, Name="Jim" }
			};

				users.ForEach(s => context.Users.Add(s));
				context.SaveChanges();

				var items = new List<Item>
			{
				new Item { Id=1, Name="Apple", Hp=5 },
				new Item { Id=2, Name="Banana", Hp=6 },
				new Item { Id=3, Name="Potion", Hp=50 },
				new Item { Id=4, Name="Super Potion", Hp=75 },
				new Item { Id=5, Name="Elixir of Life", Hp=999 }
			};

				items.ForEach(s => context.Items.Add(s));
				context.SaveChanges();

				var userItems = new List<UserItem>
			{
				new UserItem{UserId=1,ItemId=1},
				new UserItem{UserId=1,ItemId=2},
				new UserItem{UserId=2,ItemId=4},
			};
				userItems.ForEach(s => context.UserItems.Add(s));
				context.SaveChanges();
			}
		}
	}
}
