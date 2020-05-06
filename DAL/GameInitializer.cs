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
					new User{ UserID=1, Name="Elliot", Screen=1, Level=1, Exp=0, HP = 20 },
					new User{ UserID=2, Name="Other User", Screen=3, Level=1, Exp=0, HP = 19 }
				};

				users.ForEach(s => context.Users.Add(s));
				context.SaveChanges();

				var inventoryItems = new List<InventoryItem>
				{
					new InventoryItem { UserID=1, ItemID=3, ScreenItemID=0, Quantity=2 },
					new InventoryItem { UserID=2, ItemID=3, ScreenItemID=0, Quantity=2 },
					new InventoryItem { UserID=2, ItemID=1, ScreenItemID=1, Quantity=1 },
					new InventoryItem { UserID=2, ItemID=2, ScreenItemID=2, Quantity=1 }
				};

				inventoryItems.ForEach(s => context.InventoryItems.Add(s));
				context.SaveChanges();

				var screen = new List<Screen>
				{
					new Screen { ScreenID=1, Name="Dead End", Description="You stand at the end of a wide road, which continues to the west. The barren wilderness from whence you came lies to the east and south. To the north you will see a broad field surrounded by a tall fence and accessible only through a gate. A small chest sits on the ground by the fence." },
					new Screen { ScreenID=2, Name="Broad Field", Description="You stand in a broad field, freshly tilled but devoid of crops. The only exit lies south and leads to the end of a wide road." },
					new Screen { ScreenID=3, Name="Main Road", Description="You stand on a wide road which continues as far as you can see to the west. The road ends a short way east." },
					new Screen { ScreenID=4, Name="Main Road", Description="Write a description for this screen, which lies directly west of 3." },
					new Screen { ScreenID=5, Name="Chest", Description="You open the chest and look in." }
				};

				screen.ForEach(s => context.Screens.Add(s));
				context.SaveChanges();

				var accessPoint = new List<AccessPoint>
				{
					new AccessPoint { AccessPointID=1, From=1, To=2, Description="Enter the field." },
					new AccessPoint { AccessPointID=2, From=1, To=3, Description="Travel west." },
					new AccessPoint { AccessPointID=3, From=2, To=1, Description="Leave the field." },
					new AccessPoint { AccessPointID=4, From=3, To=1, Description="Travel east." },
					new AccessPoint { AccessPointID=5, From=3, To=4, Description="Travel west." },
					new AccessPoint { AccessPointID=6, From=1, To=5, Description="Open the chest." },
					new AccessPoint { AccessPointID=7, From=5, To=1, Description="Close the chest." }
				};

				accessPoint.ForEach(s => context.AccessPoints.Add(s));
				context.SaveChanges();

				var accessRequirement = new List<AccessRequirement>
				{
					new AccessRequirement { AccessRequirementID=1, AccessPointID=1, ItemID=1, ClosedMessage="The locked gate bars your way.", OpenMessage="The gate opens quietly. It must be used frequently." }
				};

				accessRequirement.ForEach(s => context.AccessRequirements.Add(s));
				context.SaveChanges();

				var itemType = new List<ItemType>
				{
					new ItemType { ItemTypeID=1, ItemType="Weapon" },
					new ItemType { ItemTypeID=2, ItemType="Consumable" },
					new ItemType { ItemTypeID=3, ItemType="Key" }
				};

				itemType.ForEach(s => context.ItemTypes.Add(s));
				context.SaveChanges();

				var item = new List<Item>
				{
					new Item { ItemID=1, ItemTypeID=3, Name="Gate Key" },
					new Item { ItemID=2, ItemTypeID=1, Name="Rusty Sickle" },
					new Item { ItemID=3, ItemTypeID=2, Name="Bread" }
				};

				item.ForEach(s => context.Items.Add(s));
				context.SaveChanges();

				var screenItem = new List<ScreenItem>
				{
					new ScreenItem { ScreenItemID=1, ScreenID=5, ItemID=1, Action="Take the gate key.", TakenDescription="You don't see anything.", Description="A key sits at the bottom of the chest. It looks like it might fit a gate." },
					new ScreenItem { ScreenItemID=2, ScreenID=2, ItemID=2, Action="Take the sickle for protection.", TakenDescription="", Description="A sickle. Serviceable, though slightly rusted, rests against a wall." }
				};

				screenItem.ForEach(s => context.ScreenItems.Add(s));
				context.SaveChanges();

				var consumable = new List<Consumable>
				{
					new Consumable { ItemID=3, Heals=5 }
				};

				consumable.ForEach(s => context.Consumables.Add(s));
				context.SaveChanges();

				var weapon = new List<Weapon>
				{
					new Weapon { ItemID=2, Multiplier=1, Die=3, Modifier=0 }
				};

				weapon.ForEach(s => context.Weapons.Add(s));
				context.SaveChanges();

				var enemy = new List<Enemy>
				{
					new Enemy { EnemyID=1, Name="Blob", Description="A strange jelly-like creature. It doesn't look very dangerous.", HP=5, Multiplier=1, Die=2, Modifier=0, Exp=5 },
					new Enemy { EnemyID=2, Name="Malnourished Bandit", Description="A bandit so gaunt you'd almost rather give him your money than fight over it. Almost.", HP=7, Multiplier=1, Die=3, Modifier=-1, Exp=10 }
				};

				enemy.ForEach(s => context.Enemies.Add(s));
				context.SaveChanges();

				var screenEnemy = new List<ScreenEnemy>
				{
					new ScreenEnemy { ScreenEnemyID=1, ScreenID=3, EnemyID=2, Action="Blocks your path." },
					new ScreenEnemy { ScreenEnemyID=2, ScreenID=3, EnemyID=2, Action="Snarls at you half-heartedly." }
				};

				screenEnemy.ForEach(s => context.ScreenEnemies.Add(s));
				context.SaveChanges();

				var fightLog = new List<FightLog>
				{
					new FightLog { UserID=2, ScreenEnemyID=1, DamageDone=2 }
				};

				fightLog.ForEach(s => context.FightLogs.Add(s));
				context.SaveChanges();
			}
		}
	}
}
