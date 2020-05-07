using Microsoft.EntityFrameworkCore.Migrations;

namespace End_of_all_Hope.Migrations
{
    public partial class TwoPointOneUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AccessPoints",
                columns: new[] { "AccessPointID", "Description", "From", "To" },
                values: new object[,]
                {
                    { 1, "Enter the field.", 1, 2 },
                    { 2, "Travel west.", 1, 3 },
                    { 3, "Leave the field.", 2, 1 },
                    { 4, "Travel east.", 3, 1 },
                    { 5, "Travel west.", 3, 4 },
                    { 6, "Open the chest.", 1, 5 },
                    { 7, "Close the chest.", 5, 1 }
                });

            migrationBuilder.InsertData(
                table: "AccessRequirements",
                columns: new[] { "AccessRequirementID", "AccessPointID", "ClosedMessage", "ItemID", "OpenMessage" },
                values: new object[] { 1, 1, "The locked gate bars your way.", 1, "The gate opens quietly. It must be used frequently." });

            migrationBuilder.InsertData(
                table: "Consumables",
                columns: new[] { "ConsumableID", "Heals", "ItemID" },
                values: new object[] { 1, 5, 3 });

            migrationBuilder.InsertData(
                table: "Enemies",
                columns: new[] { "EnemyID", "Description", "Die", "Exp", "HP", "Modifier", "Multiplier", "Name" },
                values: new object[,]
                {
                    { 2, "A bandit so gaunt you'd almost rather give him your money than fight over it. Almost.", 3, 10, 7, -1, 1, "Malnourished Bandit" },
                    { 1, "A strange jelly-like creature. It doesn't look very dangerous.", 2, 5, 5, 0, 1, "Blob" }
                });

            migrationBuilder.InsertData(
                table: "FightLogs",
                columns: new[] { "FightLogID", "DamageDone", "ScreenEnemyID", "UserID" },
                values: new object[] { 1, 2, 1, 2 });

            migrationBuilder.InsertData(
                table: "InventoryItems",
                columns: new[] { "InventoryItemID", "ItemID", "Quantity", "ScreenItemID", "UserID" },
                values: new object[,]
                {
                    { 1, 3, 2, 0, 1 },
                    { 2, 3, 2, 0, 2 },
                    { 3, 1, 1, 1, 2 },
                    { 4, 2, 1, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "ItemTypes",
                columns: new[] { "ItemTypeID", "Type" },
                values: new object[,]
                {
                    { 3, "Key" },
                    { 2, "Consumable" },
                    { 1, "Weapon" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemID", "ItemTypeID", "Name" },
                values: new object[,]
                {
                    { 1, 3, "Gate Key" },
                    { 2, 1, "Rusty Sickle" },
                    { 3, 2, "Bread" }
                });

            migrationBuilder.InsertData(
                table: "ScreenEnemies",
                columns: new[] { "ScreenEnemyID", "Action", "EnemyID", "ScreenID" },
                values: new object[,]
                {
                    { 1, "Blocks your path.", 2, 3 },
                    { 2, "Snarls at you half-heartedly.", 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "ScreenItems",
                columns: new[] { "ScreenItemID", "Action", "Description", "ItemID", "ScreenID", "TakenDescription" },
                values: new object[,]
                {
                    { 1, "Take the gate key.", "A key sits at the bottom of the chest. It looks like it might fit a gate.", 1, 5, "You don't see anything." },
                    { 2, "Take the sickle for protection.", "A sickle. Serviceable, though slightly rusted, rests against a wall.", 2, 2, "" }
                });

            migrationBuilder.InsertData(
                table: "Screens",
                columns: new[] { "ScreenID", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "You stand at the end of a wide road, which continues to the west. The barren wilderness from whence you came lies to the east and south. To the north you will see a broad field surrounded by a tall fence and accessible only through a gate. A small chest sits on the ground by the fence.", "Dead End" },
                    { 2, "You stand in a broad field, freshly tilled but devoid of crops. The only exit lies south and leads to the end of a wide road.", "Broad Field" },
                    { 3, "You stand on a wide road which continues as far as you can see to the west. The road ends a short way east.", "Main Road" },
                    { 4, "Write a description for this screen, which lies directly west of 3.", "Main Road" },
                    { 5, "You open the chest and look in.", "Chest" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Exp", "HP", "Level", "Name", "Screen" },
                values: new object[,]
                {
                    { 2, 0, 19, 1, "Other User", 3 },
                    { 1, 0, 20, 1, "Elliot", 1 }
                });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "WeaponID", "Die", "ItemID", "Modifier", "Multiplier" },
                values: new object[] { 1, 3, 2, 0, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AccessPoints",
                keyColumn: "AccessPointID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AccessPoints",
                keyColumn: "AccessPointID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AccessPoints",
                keyColumn: "AccessPointID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AccessPoints",
                keyColumn: "AccessPointID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AccessPoints",
                keyColumn: "AccessPointID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AccessPoints",
                keyColumn: "AccessPointID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AccessPoints",
                keyColumn: "AccessPointID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AccessRequirements",
                keyColumn: "AccessRequirementID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Consumables",
                keyColumn: "ConsumableID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Enemies",
                keyColumn: "EnemyID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FightLogs",
                keyColumn: "FightLogID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "InventoryItemID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "InventoryItemID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "InventoryItemID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "InventoryItems",
                keyColumn: "InventoryItemID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ItemTypes",
                keyColumn: "ItemTypeID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ScreenEnemies",
                keyColumn: "ScreenEnemyID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ScreenEnemies",
                keyColumn: "ScreenEnemyID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ScreenItems",
                keyColumn: "ScreenItemID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ScreenItems",
                keyColumn: "ScreenItemID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Screens",
                keyColumn: "ScreenID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Screens",
                keyColumn: "ScreenID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Screens",
                keyColumn: "ScreenID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Screens",
                keyColumn: "ScreenID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Screens",
                keyColumn: "ScreenID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponID",
                keyValue: 1);
        }
    }
}
