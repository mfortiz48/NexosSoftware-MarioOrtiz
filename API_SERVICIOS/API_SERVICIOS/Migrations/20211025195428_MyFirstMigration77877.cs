using Microsoft.EntityFrameworkCore.Migrations;

namespace API_SERVICIOS.Migrations
{
    public partial class MyFirstMigration77877 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "cliente_tel_mov",
                table: "Tb_Cargues",
                newName: "cargue_tel_mov");

            migrationBuilder.RenameColumn(
                name: "cliente_tel_fjo",
                table: "Tb_Cargues",
                newName: "cargue_tel_fijo");

            migrationBuilder.RenameColumn(
                name: "cliente_nombre",
                table: "Tb_Cargues",
                newName: "cargue_tecnico");

            migrationBuilder.RenameColumn(
                name: "cliente_email",
                table: "Tb_Cargues",
                newName: "cargue_serv_solic");

            migrationBuilder.RenameColumn(
                name: "cliente_dni",
                table: "Tb_Cargues",
                newName: "cargue_rer_armado");

            migrationBuilder.RenameColumn(
                name: "cliente_direccion",
                table: "Tb_Cargues",
                newName: "cargue_ref_pago");

            migrationBuilder.AddColumn<string>(
                name: "cargue_anio",
                table: "Tb_Cargues",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cargue_apr_cartera",
                table: "Tb_Cargues",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cargue_barrio",
                table: "Tb_Cargues",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cargue_carta_garantia",
                table: "Tb_Cargues",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cargue_cedula",
                table: "Tb_Cargues",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cargue_ciudad",
                table: "Tb_Cargues",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cargue_cod_postal",
                table: "Tb_Cargues",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cargue_cod_servicio",
                table: "Tb_Cargues",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cargue_cod_vendedor",
                table: "Tb_Cargues",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cargue_consecutivo",
                table: "Tb_Cargues",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cargue_cta_cliente",
                table: "Tb_Cargues",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cargue_direccion",
                table: "Tb_Cargues",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cargue_email",
                table: "Tb_Cargues",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cargue_equipo",
                table: "Tb_Cargues",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cargue_est_orden",
                table: "Tb_Cargues",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cargue_factura",
                table: "Tb_Cargues",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cargue_factura_2",
                table: "Tb_Cargues",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cargue_fec_atencion",
                table: "Tb_Cargues",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cargue_fec_compra",
                table: "Tb_Cargues",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cargue_fec_pago",
                table: "Tb_Cargues",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cargue_fec_reporte",
                table: "Tb_Cargues",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cargue_incidencia",
                table: "Tb_Cargues",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cargue_lugar_compra",
                table: "Tb_Cargues",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cargue_mes",
                table: "Tb_Cargues",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cargue_nombre",
                table: "Tb_Cargues",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cargue_observaciones",
                table: "Tb_Cargues",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cargue_pago",
                table: "Tb_Cargues",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cargue_anio",
                table: "Tb_Cargues");

            migrationBuilder.DropColumn(
                name: "cargue_apr_cartera",
                table: "Tb_Cargues");

            migrationBuilder.DropColumn(
                name: "cargue_barrio",
                table: "Tb_Cargues");

            migrationBuilder.DropColumn(
                name: "cargue_carta_garantia",
                table: "Tb_Cargues");

            migrationBuilder.DropColumn(
                name: "cargue_cedula",
                table: "Tb_Cargues");

            migrationBuilder.DropColumn(
                name: "cargue_ciudad",
                table: "Tb_Cargues");

            migrationBuilder.DropColumn(
                name: "cargue_cod_postal",
                table: "Tb_Cargues");

            migrationBuilder.DropColumn(
                name: "cargue_cod_servicio",
                table: "Tb_Cargues");

            migrationBuilder.DropColumn(
                name: "cargue_cod_vendedor",
                table: "Tb_Cargues");

            migrationBuilder.DropColumn(
                name: "cargue_consecutivo",
                table: "Tb_Cargues");

            migrationBuilder.DropColumn(
                name: "cargue_cta_cliente",
                table: "Tb_Cargues");

            migrationBuilder.DropColumn(
                name: "cargue_direccion",
                table: "Tb_Cargues");

            migrationBuilder.DropColumn(
                name: "cargue_email",
                table: "Tb_Cargues");

            migrationBuilder.DropColumn(
                name: "cargue_equipo",
                table: "Tb_Cargues");

            migrationBuilder.DropColumn(
                name: "cargue_est_orden",
                table: "Tb_Cargues");

            migrationBuilder.DropColumn(
                name: "cargue_factura",
                table: "Tb_Cargues");

            migrationBuilder.DropColumn(
                name: "cargue_factura_2",
                table: "Tb_Cargues");

            migrationBuilder.DropColumn(
                name: "cargue_fec_atencion",
                table: "Tb_Cargues");

            migrationBuilder.DropColumn(
                name: "cargue_fec_compra",
                table: "Tb_Cargues");

            migrationBuilder.DropColumn(
                name: "cargue_fec_pago",
                table: "Tb_Cargues");

            migrationBuilder.DropColumn(
                name: "cargue_fec_reporte",
                table: "Tb_Cargues");

            migrationBuilder.DropColumn(
                name: "cargue_incidencia",
                table: "Tb_Cargues");

            migrationBuilder.DropColumn(
                name: "cargue_lugar_compra",
                table: "Tb_Cargues");

            migrationBuilder.DropColumn(
                name: "cargue_mes",
                table: "Tb_Cargues");

            migrationBuilder.DropColumn(
                name: "cargue_nombre",
                table: "Tb_Cargues");

            migrationBuilder.DropColumn(
                name: "cargue_observaciones",
                table: "Tb_Cargues");

            migrationBuilder.DropColumn(
                name: "cargue_pago",
                table: "Tb_Cargues");

            migrationBuilder.RenameColumn(
                name: "cargue_tel_mov",
                table: "Tb_Cargues",
                newName: "cliente_tel_mov");

            migrationBuilder.RenameColumn(
                name: "cargue_tel_fijo",
                table: "Tb_Cargues",
                newName: "cliente_tel_fjo");

            migrationBuilder.RenameColumn(
                name: "cargue_tecnico",
                table: "Tb_Cargues",
                newName: "cliente_nombre");

            migrationBuilder.RenameColumn(
                name: "cargue_serv_solic",
                table: "Tb_Cargues",
                newName: "cliente_email");

            migrationBuilder.RenameColumn(
                name: "cargue_rer_armado",
                table: "Tb_Cargues",
                newName: "cliente_dni");

            migrationBuilder.RenameColumn(
                name: "cargue_ref_pago",
                table: "Tb_Cargues",
                newName: "cliente_direccion");
        }
    }
}
