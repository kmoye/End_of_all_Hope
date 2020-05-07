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

		public GameContext()
			: base()
		{ }

		public DbSet<AccessPoint> AccessPoints { get; set; }
		public DbSet<AccessRequirement> AccessRequirements { get; set; }
		public DbSet<Consumable> Consumables { get; set; }
		public DbSet<Enemy> Enemies { get; set; }
		public DbSet<FightLog> FightLogs { get; set; }
		public DbSet<InventoryItem> InventoryItems { get; set; }
		public DbSet<Item> Items { get; set; }
		public DbSet<ItemType> ItemTypes { get; set; }
		public DbSet<Screen> Screens { get; set; }
		public DbSet<ScreenEnemy> ScreenEnemies { get; set; }
		public DbSet<ScreenItem> ScreenItems { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<UserItem> UserItems { get; set; }
		public DbSet<Weapon> Weapons { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<User>().HasData(
				new User { UserID = 1, Name = "Elliot", Screen = 1, Level = 1, Exp = 0, HP = 20 },
				new User { UserID = 2, Name = "Other User", Screen = 3, Level = 1, Exp = 0, HP = 19 }
			);


			modelBuilder.Entity<InventoryItem>().HasData(
				new InventoryItem { InventoryItemID = 1, UserID = 1, ItemID = 3, ScreenItemID = 0, Quantity = 2 },
				new InventoryItem { InventoryItemID = 2, UserID = 2, ItemID = 3, ScreenItemID = 0, Quantity = 2 },
				new InventoryItem { InventoryItemID = 3, UserID = 2, ItemID = 1, ScreenItemID = 1, Quantity = 1 },
				new InventoryItem { InventoryItemID = 4, UserID = 2, ItemID = 2, ScreenItemID = 2, Quantity = 1 }
			);

			modelBuilder.Entity<Screen>().HasData(
				new Screen { ScreenID = 1, Name = "Dead End", Description = "You stand at the end of a wide road, which continues to the west. The barren wilderness from whence you came lies to the east and south. To the north you will see a broad field surrounded by a tall fence and accessible only through a gate. A small chest sits on the ground by the fence." },
				new Screen { ScreenID = 2, Name = "Broad Field", Description = "You stand in a broad field, freshly tilled but devoid of crops. The only exit lies south and leads to the end of a wide road." },
				new Screen { ScreenID = 3, Name = "Main Road", Description = "You stand on a wide road which continues as far as you can see to the west. The road ends a short way east." },
				new Screen { ScreenID = 4, Name = "Main Road", Description = "Write a description for this screen, which lies directly west of 3." },
				new Screen { ScreenID = 5, Name = "Chest", Description = "You open the chest and look in." }
			);

			modelBuilder.Entity<AccessPoint>().HasData(
				new AccessPoint { AccessPointID = 1, From = 1, To = 2, Description = "Enter the field." },
				new AccessPoint { AccessPointID = 2, From = 1, To = 3, Description = "Travel west." },
				new AccessPoint { AccessPointID = 3, From = 2, To = 1, Description = "Leave the field." },
				new AccessPoint { AccessPointID = 4, From = 3, To = 1, Description = "Travel east." },
				new AccessPoint { AccessPointID = 5, From = 3, To = 4, Description = "Travel west." },
				new AccessPoint { AccessPointID = 6, From = 1, To = 5, Description = "Open the chest." },
				new AccessPoint { AccessPointID = 7, From = 5, To = 1, Description = "Close the chest." }
			);

			modelBuilder.Entity<AccessRequirement>().HasData(
				new AccessRequirement { AccessRequirementID = 1, AccessPointID = 1, ItemID = 1, ClosedMessage = "The locked gate bars your way.", OpenMessage = "The gate opens quietly. It must be used frequently." }
			);

			modelBuilder.Entity<ItemType>().HasData(
				new ItemType { ItemTypeID = 1, Type = "Weapon" },
				new ItemType { ItemTypeID = 2, Type = "Consumable" },
				new ItemType { ItemTypeID = 3, Type = "Key" }
			);

			modelBuilder.Entity<Item>().HasData(
				new Item { ItemID = 1, ItemTypeID = 3, Name = "Gate Key" },
				new Item { ItemID = 2, ItemTypeID = 1, Name = "Rusty Sickle" },
				new Item { ItemID = 3, ItemTypeID = 2, Name = "Bread" }
			);

			modelBuilder.Entity<ScreenItem>().HasData(
				new ScreenItem { ScreenItemID = 1, ScreenID = 5, ItemID = 1, Action = "Take the gate key.", TakenDescription = "You don't see anything.", Description = "A key sits at the bottom of the chest. It looks like it might fit a gate." },
				new ScreenItem { ScreenItemID = 2, ScreenID = 2, ItemID = 2, Action = "Take the sickle for protection.", TakenDescription = "", Description = "A sickle. Serviceable, though slightly rusted, rests against a wall." }
			);

			modelBuilder.Entity<Consumable>().HasData(
				new Consumable { ConsumableID = 1, ItemID = 3, Heals = 5 }
			);

			modelBuilder.Entity<Weapon>().HasData(
				new Weapon { WeaponID = 1, ItemID = 2, Multiplier = 1, Die = 3, Modifier = 0 }
			);

			modelBuilder.Entity<Enemy>().HasData(
				new Enemy { EnemyID = 1, Name = "Blob", Description = "A strange jelly-like creature. It doesn't look very dangerous.", HP = 5, Multiplier = 1, Die = 2, Modifier = 0, Exp = 5 },
				new Enemy { EnemyID = 2, Name = "Malnourished Bandit", Description = "A bandit so gaunt you'd almost rather give him your money than fight over it. Almost.", HP = 7, Multiplier = 1, Die = 3, Modifier = -1, Exp = 10 }
			);

			modelBuilder.Entity<ScreenEnemy>().HasData(
				new ScreenEnemy { ScreenEnemyID = 1, ScreenID = 3, EnemyID = 2, Action = "Blocks your path." },
				new ScreenEnemy { ScreenEnemyID = 2, ScreenID = 3, EnemyID = 2, Action = "Snarls at you half-heartedly." }
			);

			modelBuilder.Entity<FightLog>().HasData(
				new FightLog { FightLogID = 1, UserID = 2, ScreenEnemyID = 1, DamageDone = 2 }
			);
		}
	}
}
