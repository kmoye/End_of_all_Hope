using Microsoft.EntityFrameworkCore.Migrations;

namespace End_of_all_Hope.Migrations
{
    public partial class TechnicallyDatabaseFirst : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Users_UserId",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Items",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_UserId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Hp",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Items");

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Users",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Exp",
                table: "Users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HP",
                table: "Users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Level",
                table: "Users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Screen",
                table: "Users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ItemID",
                table: "Items",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ItemTypeID",
                table: "Items",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "UserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Items",
                table: "Items",
                column: "ItemID");

            migrationBuilder.CreateTable(
                name: "AccessPoints",
                columns: table => new
                {
                    AccessPointID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    From = table.Column<int>(nullable: false),
                    To = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessPoints", x => x.AccessPointID);
                });

            migrationBuilder.CreateTable(
                name: "AccessRequirements",
                columns: table => new
                {
                    AccessRequirementID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccessPointID = table.Column<int>(nullable: false),
                    ItemID = table.Column<int>(nullable: false),
                    ClosedMessage = table.Column<string>(nullable: true),
                    OpenMessage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessRequirements", x => x.AccessRequirementID);
                });

            migrationBuilder.CreateTable(
                name: "Consumables",
                columns: table => new
                {
                    ConsumableID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemID = table.Column<int>(nullable: false),
                    Heals = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consumables", x => x.ConsumableID);
                });

            migrationBuilder.CreateTable(
                name: "Enemies",
                columns: table => new
                {
                    EnemyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    HP = table.Column<int>(nullable: false),
                    Multiplier = table.Column<int>(nullable: false),
                    Die = table.Column<int>(nullable: false),
                    Modifier = table.Column<int>(nullable: false),
                    Exp = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enemies", x => x.EnemyID);
                });

            migrationBuilder.CreateTable(
                name: "FightLogs",
                columns: table => new
                {
                    FightLogID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(nullable: false),
                    ScreenEnemyID = table.Column<int>(nullable: false),
                    DamageDone = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FightLogs", x => x.FightLogID);
                });

            migrationBuilder.CreateTable(
                name: "InventoryItems",
                columns: table => new
                {
                    InventoryItemID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(nullable: false),
                    ItemID = table.Column<int>(nullable: false),
                    ScreenItemID = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryItems", x => x.InventoryItemID);
                });

            migrationBuilder.CreateTable(
                name: "ItemTypes",
                columns: table => new
                {
                    ItemTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemTypes", x => x.ItemTypeID);
                });

            migrationBuilder.CreateTable(
                name: "ScreenEnemies",
                columns: table => new
                {
                    ScreenEnemyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScreenID = table.Column<int>(nullable: false),
                    EnemyID = table.Column<int>(nullable: false),
                    Action = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScreenEnemies", x => x.ScreenEnemyID);
                });

            migrationBuilder.CreateTable(
                name: "ScreenItems",
                columns: table => new
                {
                    ScreenItemID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScreenID = table.Column<int>(nullable: false),
                    ItemID = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    TakenDescription = table.Column<string>(nullable: true),
                    Action = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScreenItems", x => x.ScreenItemID);
                });

            migrationBuilder.CreateTable(
                name: "Screens",
                columns: table => new
                {
                    ScreenID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Screens", x => x.ScreenID);
                });

            migrationBuilder.CreateTable(
                name: "Weapons",
                columns: table => new
                {
                    WeaponID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemID = table.Column<int>(nullable: false),
                    Multiplier = table.Column<int>(nullable: false),
                    Die = table.Column<int>(nullable: false),
                    Modifier = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.WeaponID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccessPoints");

            migrationBuilder.DropTable(
                name: "AccessRequirements");

            migrationBuilder.DropTable(
                name: "Consumables");

            migrationBuilder.DropTable(
                name: "Enemies");

            migrationBuilder.DropTable(
                name: "FightLogs");

            migrationBuilder.DropTable(
                name: "InventoryItems");

            migrationBuilder.DropTable(
                name: "ItemTypes");

            migrationBuilder.DropTable(
                name: "ScreenEnemies");

            migrationBuilder.DropTable(
                name: "ScreenItems");

            migrationBuilder.DropTable(
                name: "Screens");

            migrationBuilder.DropTable(
                name: "Weapons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Items",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Exp",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "HP",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Level",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Screen",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ItemID",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ItemTypeID",
                table: "Items");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Hp",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Items",
                table: "Items",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Items_UserId",
                table: "Items",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Users_UserId",
                table: "Items",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
