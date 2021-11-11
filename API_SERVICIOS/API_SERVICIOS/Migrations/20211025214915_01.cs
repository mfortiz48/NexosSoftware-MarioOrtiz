using Microsoft.EntityFrameworkCore.Migrations;

namespace API_SERVICIOS.Migrations
{
    public partial class _01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "cliente_tpo",
                table: "Tb_Clientes",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cliente_tpo",
                table: "Tb_Clientes");
        }
    }
}
