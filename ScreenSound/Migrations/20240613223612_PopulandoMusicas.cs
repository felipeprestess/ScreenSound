using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    /// <inheritdoc />
    public partial class PopulandoMusicas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Musicas", 
                new string[] { "Nome", "AnoLancamento" }, 
                new object[] { "Mr. Brightside", 2003 });

            migrationBuilder.InsertData("Musicas",
                new string[] { "Nome", "AnoLancamento" },
                new object[] { "De Repente California", 1982 });

            migrationBuilder.InsertData("Musicas",
                new string[] { "Nome", "AnoLancamento" },
                new object[] { "Suedehead", 1988 });

            migrationBuilder.InsertData("Musicas",
                new string[] { "Nome", "AnoLancamento" },
                new object[] { "Gloria", 1981 });

            migrationBuilder.InsertData("Musicas",
                new string[] { "Nome", "AnoLancamento" },
                new object[] { "Times Like These", 2002 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Musicas");
        }
    }
}
