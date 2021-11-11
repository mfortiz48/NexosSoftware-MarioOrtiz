using Microsoft.EntityFrameworkCore.Migrations;

namespace API_SERVICIOS.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tb_libros",
                columns: table => new
                {
                    cliente_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cliente_dni = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cliente_nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cliente_email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cliente_direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cliente_tel_fjo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cliente_tel_mov = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_libros", x => x.cliente_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tb_libros");
        }
    }
}
