using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Username = table.Column<string>(maxLength: 20, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    ThisWeekID = table.Column<int>(nullable: false),
                    NextWeekID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "GroceryList",
                columns: table => new
                {
                    ListID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ListName = table.Column<string>(nullable: false),
                    CreatorID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroceryList", x => x.ListID);
                    table.ForeignKey(
                        name: "FK_GroceryList_Users_CreatorID",
                        column: x => x.CreatorID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    RecipeID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    PrepTimeInt = table.Column<int>(nullable: false),
                    PrepTimeString = table.Column<string>(nullable: false),
                    Instructions = table.Column<string>(nullable: true),
                    CreatedID = table.Column<string>(nullable: true),
                    CreatorID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.RecipeID);
                    table.ForeignKey(
                        name: "FK_Recipes_Users_CreatorID",
                        column: x => x.CreatorID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Weeks",
                columns: table => new
                {
                    WeekID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weeks", x => x.WeekID);
                    table.ForeignKey(
                        name: "FK_Weeks_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GUAssoc",
                columns: table => new
                {
                    GUAssocID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserID = table.Column<int>(nullable: false),
                    ListID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GUAssoc", x => x.GUAssocID);
                    table.ForeignKey(
                        name: "FK_GUAssoc_GroceryList_ListID",
                        column: x => x.ListID,
                        principalTable: "GroceryList",
                        principalColumn: "ListID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GUAssoc_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ingriedients",
                columns: table => new
                {
                    IngriedientID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    AmountNum = table.Column<double>(nullable: false),
                    AmountString = table.Column<string>(nullable: false),
                    CreatedId = table.Column<string>(nullable: true),
                    GroceryListListID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingriedients", x => x.IngriedientID);
                    table.ForeignKey(
                        name: "FK_Ingriedients_GroceryList_GroceryListListID",
                        column: x => x.GroceryListListID,
                        principalTable: "GroceryList",
                        principalColumn: "ListID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RUAssoc",
                columns: table => new
                {
                    RUAssocID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserID = table.Column<int>(nullable: false),
                    RecipeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RUAssoc", x => x.RUAssocID);
                    table.ForeignKey(
                        name: "FK_RUAssoc_Recipes_RecipeID",
                        column: x => x.RecipeID,
                        principalTable: "Recipes",
                        principalColumn: "RecipeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RUAssoc_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Days",
                columns: table => new
                {
                    DayID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    date = table.Column<DateTime>(nullable: false),
                    WeekID = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Days", x => x.DayID);
                    table.ForeignKey(
                        name: "FK_Days_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Days_Weeks_WeekID",
                        column: x => x.WeekID,
                        principalTable: "Weeks",
                        principalColumn: "WeekID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GIAssoc",
                columns: table => new
                {
                    GIAssocID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IngriedientID = table.Column<int>(nullable: false),
                    AmountInt = table.Column<int>(nullable: false),
                    AmountString = table.Column<string>(nullable: false),
                    ListID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GIAssoc", x => x.GIAssocID);
                    table.ForeignKey(
                        name: "FK_GIAssoc_Ingriedients_IngriedientID",
                        column: x => x.IngriedientID,
                        principalTable: "Ingriedients",
                        principalColumn: "IngriedientID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GIAssoc_GroceryList_ListID",
                        column: x => x.ListID,
                        principalTable: "GroceryList",
                        principalColumn: "ListID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RIAssocs",
                columns: table => new
                {
                    RIAssocID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IngriedientID = table.Column<int>(nullable: false),
                    RecipeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RIAssocs", x => x.RIAssocID);
                    table.ForeignKey(
                        name: "FK_RIAssocs_Ingriedients_IngriedientID",
                        column: x => x.IngriedientID,
                        principalTable: "Ingriedients",
                        principalColumn: "IngriedientID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RIAssocs_Recipes_RecipeID",
                        column: x => x.RecipeID,
                        principalTable: "Recipes",
                        principalColumn: "RecipeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Breakfasts",
                columns: table => new
                {
                    BreakfastID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DayID = table.Column<int>(nullable: false),
                    RecipeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Breakfasts", x => x.BreakfastID);
                    table.ForeignKey(
                        name: "FK_Breakfasts_Days_DayID",
                        column: x => x.DayID,
                        principalTable: "Days",
                        principalColumn: "DayID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Breakfasts_Recipes_RecipeID",
                        column: x => x.RecipeID,
                        principalTable: "Recipes",
                        principalColumn: "RecipeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dinners",
                columns: table => new
                {
                    DinnerID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DayID = table.Column<int>(nullable: false),
                    RecipeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dinners", x => x.DinnerID);
                    table.ForeignKey(
                        name: "FK_Dinners_Days_DayID",
                        column: x => x.DayID,
                        principalTable: "Days",
                        principalColumn: "DayID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Dinners_Recipes_RecipeID",
                        column: x => x.RecipeID,
                        principalTable: "Recipes",
                        principalColumn: "RecipeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lunches",
                columns: table => new
                {
                    LunchID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DayID = table.Column<int>(nullable: false),
                    RecipeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lunches", x => x.LunchID);
                    table.ForeignKey(
                        name: "FK_Lunches_Days_DayID",
                        column: x => x.DayID,
                        principalTable: "Days",
                        principalColumn: "DayID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lunches_Recipes_RecipeID",
                        column: x => x.RecipeID,
                        principalTable: "Recipes",
                        principalColumn: "RecipeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Breakfasts_DayID",
                table: "Breakfasts",
                column: "DayID");

            migrationBuilder.CreateIndex(
                name: "IX_Breakfasts_RecipeID",
                table: "Breakfasts",
                column: "RecipeID");

            migrationBuilder.CreateIndex(
                name: "IX_Days_UserID",
                table: "Days",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Days_WeekID",
                table: "Days",
                column: "WeekID");

            migrationBuilder.CreateIndex(
                name: "IX_Dinners_DayID",
                table: "Dinners",
                column: "DayID");

            migrationBuilder.CreateIndex(
                name: "IX_Dinners_RecipeID",
                table: "Dinners",
                column: "RecipeID");

            migrationBuilder.CreateIndex(
                name: "IX_GIAssoc_IngriedientID",
                table: "GIAssoc",
                column: "IngriedientID");

            migrationBuilder.CreateIndex(
                name: "IX_GIAssoc_ListID",
                table: "GIAssoc",
                column: "ListID");

            migrationBuilder.CreateIndex(
                name: "IX_GroceryList_CreatorID",
                table: "GroceryList",
                column: "CreatorID");

            migrationBuilder.CreateIndex(
                name: "IX_GUAssoc_ListID",
                table: "GUAssoc",
                column: "ListID");

            migrationBuilder.CreateIndex(
                name: "IX_GUAssoc_UserID",
                table: "GUAssoc",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Ingriedients_GroceryListListID",
                table: "Ingriedients",
                column: "GroceryListListID");

            migrationBuilder.CreateIndex(
                name: "IX_Lunches_DayID",
                table: "Lunches",
                column: "DayID");

            migrationBuilder.CreateIndex(
                name: "IX_Lunches_RecipeID",
                table: "Lunches",
                column: "RecipeID");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_CreatorID",
                table: "Recipes",
                column: "CreatorID");

            migrationBuilder.CreateIndex(
                name: "IX_RIAssocs_IngriedientID",
                table: "RIAssocs",
                column: "IngriedientID");

            migrationBuilder.CreateIndex(
                name: "IX_RIAssocs_RecipeID",
                table: "RIAssocs",
                column: "RecipeID");

            migrationBuilder.CreateIndex(
                name: "IX_RUAssoc_RecipeID",
                table: "RUAssoc",
                column: "RecipeID");

            migrationBuilder.CreateIndex(
                name: "IX_RUAssoc_UserID",
                table: "RUAssoc",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Weeks_UserID",
                table: "Weeks",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Breakfasts");

            migrationBuilder.DropTable(
                name: "Dinners");

            migrationBuilder.DropTable(
                name: "GIAssoc");

            migrationBuilder.DropTable(
                name: "GUAssoc");

            migrationBuilder.DropTable(
                name: "Lunches");

            migrationBuilder.DropTable(
                name: "RIAssocs");

            migrationBuilder.DropTable(
                name: "RUAssoc");

            migrationBuilder.DropTable(
                name: "Days");

            migrationBuilder.DropTable(
                name: "Ingriedients");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "Weeks");

            migrationBuilder.DropTable(
                name: "GroceryList");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
