using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projektInterferfejsy.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nazwisko = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Haslo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Diety",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diety", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Diety_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Przepisy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CzasPrzygotowania = table.Column<int>(type: "int", nullable: true),
                    Trudnosc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Przepisy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Przepisy_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Produkty",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kalorie = table.Column<int>(type: "int", nullable: true),
                    Bialko = table.Column<int>(type: "int", nullable: true),
                    Weglowodany = table.Column<int>(type: "int", nullable: true),
                    Tluszcze = table.Column<int>(type: "int", nullable: true),
                    DietaId = table.Column<int>(type: "int", nullable: true),
                    PrzepisId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produkty", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produkty_Diety_DietaId",
                         studcolumn: x => x.DietaId,
                        principalTable: "Diety",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Produkty_Przepisy_PrzepisId",
                        column: x => x.PrzepisId,
                        principalTable: "Przepisy",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Diety_UserId",
                table: "Diety",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Produkty_DietaId",
                table: "Produkty",
                column: "DietaId");

            migrationBuilder.CreateIndex(
                name: "IX_Produkty_PrzepisId",
                table: "Produkty",
                column: "PrzepisId");

            migrationBuilder.CreateIndex(
                name: "IX_Przepisy_UserId",
                table: "Przepisy",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produkty");

            migrationBuilder.DropTable(
                name: "Diety");

            migrationBuilder.DropTable(
                name: "Przepisy");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
