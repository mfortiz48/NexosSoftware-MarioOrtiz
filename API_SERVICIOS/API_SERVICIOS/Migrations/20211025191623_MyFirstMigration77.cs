using Microsoft.EntityFrameworkCore.Migrations;

namespace API_SERVICIOS.Migrations
{
    public partial class MyFirstMigration77 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tb_libros",
                table: "Tb_libros");

            migrationBuilder.RenameTable(
                name: "Tb_libros",
                newName: "Tb_Clientes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tb_Clientes",
                table: "Tb_Clientes",
                column: "cliente_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tb_Clientes",
                table: "Tb_Clientes");

            migrationBuilder.RenameTable(
                name: "Tb_Clientes",
                newName: "Tb_libros");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tb_libros",
                table: "Tb_libros",
                column: "cliente_id");
        }
    }
}
