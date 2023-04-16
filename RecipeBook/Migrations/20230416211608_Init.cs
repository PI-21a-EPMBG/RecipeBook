using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecipeBook.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cookery",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cookery", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ingridient",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ingridient", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "measure_unit",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_measure_unit", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tags",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tags", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "dish",
                columns: table => new
                {
                    id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    description = table.Column<string>(type: "TEXT", nullable: false),
                    recipe = table.Column<long>(type: "INTEGER", nullable: true),
                    cookery_id = table.Column<long>(type: "INTEGER", nullable: false),
                    cooking_time = table.Column<long>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dish", x => x.id);
                    table.ForeignKey(
                        name: "FK_dish_cookery_cookery_id",
                        column: x => x.cookery_id,
                        principalTable: "cookery",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "dish_ingridients",
                columns: table => new
                {
                    dish_id = table.Column<long>(type: "INTEGER", nullable: false),
                    ingridient_id = table.Column<long>(type: "INTEGER", nullable: false),
                    quantity = table.Column<long>(type: "INTEGER", nullable: false),
                    measure_unit_id = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_dish_ingridients_dish_dish_id",
                        column: x => x.dish_id,
                        principalTable: "dish",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_dish_ingridients_ingridient_ingridient_id",
                        column: x => x.ingridient_id,
                        principalTable: "ingridient",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_dish_ingridients_measure_unit_measure_unit_id",
                        column: x => x.measure_unit_id,
                        principalTable: "measure_unit",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "dish_tag",
                columns: table => new
                {
                    dish_id = table.Column<long>(type: "INTEGER", nullable: false),
                    tag_id = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_dish_tag_dish_dish_id",
                        column: x => x.dish_id,
                        principalTable: "dish",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_dish_tag_tags_tag_id",
                        column: x => x.tag_id,
                        principalTable: "tags",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "favorites",
                columns: table => new
                {
                    dish_id = table.Column<long>(type: "INTEGER", nullable: false),
                    date_added = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_favorites_dish_dish_id",
                        column: x => x.dish_id,
                        principalTable: "dish",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_cookery_id",
                table: "cookery",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_dish_cookery_id",
                table: "dish",
                column: "cookery_id");

            migrationBuilder.CreateIndex(
                name: "IX_dish_id",
                table: "dish",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_dish_name",
                table: "dish",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_dish_ingridients_dish_id",
                table: "dish_ingridients",
                column: "dish_id");

            migrationBuilder.CreateIndex(
                name: "IX_dish_ingridients_ingridient_id",
                table: "dish_ingridients",
                column: "ingridient_id");

            migrationBuilder.CreateIndex(
                name: "IX_dish_ingridients_measure_unit_id",
                table: "dish_ingridients",
                column: "measure_unit_id");

            migrationBuilder.CreateIndex(
                name: "IX_dish_tag_dish_id",
                table: "dish_tag",
                column: "dish_id");

            migrationBuilder.CreateIndex(
                name: "IX_dish_tag_tag_id",
                table: "dish_tag",
                column: "tag_id");

            migrationBuilder.CreateIndex(
                name: "IX_favorites_dish_id",
                table: "favorites",
                column: "dish_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ingridient_id",
                table: "ingridient",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ingridient_name",
                table: "ingridient",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_measure_unit_id",
                table: "measure_unit",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_measure_unit_name",
                table: "measure_unit",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tags_id",
                table: "tags",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tags_name",
                table: "tags",
                column: "name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dish_ingridients");

            migrationBuilder.DropTable(
                name: "dish_tag");

            migrationBuilder.DropTable(
                name: "favorites");

            migrationBuilder.DropTable(
                name: "ingridient");

            migrationBuilder.DropTable(
                name: "measure_unit");

            migrationBuilder.DropTable(
                name: "tags");

            migrationBuilder.DropTable(
                name: "dish");

            migrationBuilder.DropTable(
                name: "cookery");
        }
    }
}
