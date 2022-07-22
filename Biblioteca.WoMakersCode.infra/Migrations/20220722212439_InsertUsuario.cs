using Microsoft.EntityFrameworkCore.Migrations;

namespace Biblioteca.WoMakersCode.infra.Migrations
{
    public partial class InsertUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO usuarios(nome, endereco, telefone) values ('Jamile', 'Rua x', '5555555')");
            migrationBuilder.Sql("INSERT INTO usuarios(nome, endereco, telefone) values ('Jessica', 'Rua y', '000000')");
            migrationBuilder.Sql("INSERT INTO usuarios(nome, endereco, telefone) values ('Drycca', 'Rua z', '1111111')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
