using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    /// <inheritdoc />
    public partial class PopularTabela : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Artistas",
                new string[] { "Nome", "Bio", "FotoPerfil" },
                new object[] {"Foo Fighters", "Uma banda foda demais",
                "https://cdn.pixabay.com/photo/2016/08/08/09/17/avatar-1577909_1280.png" });

            migrationBuilder.InsertData("Artistas",
                new string[] { "Nome", "Bio", "FotoPerfil" },
                new object[] {"U2", "U2 é uma banda irlandesa de rock formada no ano de 1976. O grupo é composto por Bono, The Edge, Adam Clayton (baixo) e Larry Mullen Jr.. Inicialmente, o gosto musical possuía influências no gênero pós-punk, porém, eventualmente foram incorporando estilos mais genéricos.",
                "https://cdn.pixabay.com/photo/2016/08/08/09/17/avatar-1577909_1280.png" });

            migrationBuilder.InsertData("Artistas",
                new string[] { "Nome", "Bio", "FotoPerfil" },
                new object[] {"Lulu Santos", "Luiz Maurício Pragana dos Santos (Rio de Janeiro, 4 de maio de 1953), mais conhecido como Lulu Santos, é um cantor, compositor, produtor musical e guitarrista brasileiro.",
                "https://cdn.pixabay.com/photo/2016/08/08/09/17/avatar-1577909_1280.png" });

            migrationBuilder.InsertData("Artistas",
                new string[] { "Nome", "Bio", "FotoPerfil" },
                new object[] {"The Smiths", "The Smiths foi uma banda britânica de rock, fundada em Manchester em 1982. Tendo como principal característica a parceria nas composições de Morrissey (vocal) e Johnny Marr (guitarras), a banda também incluía Andy Rourke no baixo e Mike Joyce como baterista",
                "https://cdn.pixabay.com/photo/2016/08/08/09/17/avatar-1577909_1280.png" });

            migrationBuilder.InsertData("Artistas",
                new string[] { "Nome", "Bio", "FotoPerfil" },
                new object[] {"The Killers", "The Killers é uma banda americana de rock, formada no ano de 2001 em Las Vegas. É composta por Brandon Flowers (vocais e sintetizador), Dave Keuning (guitarra e vocal de apoio), Ronnie Vannucci (bateria) e Mark Stoermer (baixo e vocal de apoio).[3] Seu primeiro álbum, Hot Fuss, foi lançado em 15 de junho de 2004,[4] obtendo ótimas críticas e grande reconhecimento junto ao público, em grande parte devido aos sucessos \"Somebody Told Me\", \"Mr. Brightside\" e à sonoridade dançante dos anos 80, oriunda dos sons sintéticos das canções.",
                "https://cdn.pixabay.com/photo/2016/08/08/09/17/avatar-1577909_1280.png" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Artistas");
        }
    }
}
