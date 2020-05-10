using Microsoft.EntityFrameworkCore.Migrations;

namespace WynikiSkokow.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Skoczek",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imie = table.Column<string>(nullable: true),
                    Nazwisko = table.Column<string>(nullable: true),
                    Kraj = table.Column<string>(nullable: true),
                    Skok1 = table.Column<decimal>(nullable: false),
                    Skok2 = table.Column<decimal>(nullable: false),
                    Punkty = table.Column<decimal>(nullable: false),
                    Miejsce = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skoczek", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Skoczek");
        }
    }
}
