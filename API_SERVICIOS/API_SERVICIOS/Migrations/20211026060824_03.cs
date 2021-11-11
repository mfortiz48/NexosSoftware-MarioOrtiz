using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API_SERVICIOS.Migrations
{
    public partial class _03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tb_direccionCliente",
                columns: table => new
                {
                    direccionCliente_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    direccionCliente_Cliente_Id = table.Column<long>(type: "bigint", nullable: false),
                    direccionCliente_Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    direccionCliente_coordenada_x = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    direccionCliente_coordenada_y = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    direccionCliente_estado = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_direccionCliente", x => x.direccionCliente_id);
                    table.ForeignKey(
                        name: "FK_Tb_direccionCliente_Tb_Clientes_direccionCliente_Cliente_Id",
                        column: x => x.direccionCliente_Cliente_Id,
                        principalTable: "Tb_Clientes",
                        principalColumn: "cliente_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tb_servicio_tpo",
                columns: table => new
                {
                    servicio_tpo_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    servicio_tpo_cod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    servicio_tpo_descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    servicio_tpo_estado = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_servicio_tpo", x => x.servicio_tpo_id);
                });

            migrationBuilder.CreateTable(
                name: "Tb_tecnico",
                columns: table => new
                {
                    tecnico_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tecnico_dni = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tecnico_nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tecnico_email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tecnico_direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tecnico_estado = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_tecnico", x => x.tecnico_id);
                });

            migrationBuilder.CreateTable(
                name: "Tb_servicio",
                columns: table => new
                {
                    servicio_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    servicio_consecutivo = table.Column<long>(type: "bigint", nullable: false),
                    servicio_cliente_id = table.Column<long>(type: "bigint", nullable: false),
                    servicio_fechaApertura = table.Column<DateTime>(type: "datetime2", nullable: false),
                    servicio_Fecha_gestion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Servicio_Tecnico_Id = table.Column<long>(type: "bigint", nullable: false),
                    Servicio_Observacion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_servicio", x => x.servicio_id);
                    table.ForeignKey(
                        name: "FK_Tb_servicio_Tb_Clientes_servicio_cliente_id",
                        column: x => x.servicio_cliente_id,
                        principalTable: "Tb_Clientes",
                        principalColumn: "cliente_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tb_servicio_Tb_tecnico_Servicio_Tecnico_Id",
                        column: x => x.Servicio_Tecnico_Id,
                        principalTable: "Tb_tecnico",
                        principalColumn: "tecnico_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tb_servicioDetalle",
                columns: table => new
                {
                    servicioDetalle_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    servicioDetalle_Servicio_id = table.Column<long>(type: "bigint", nullable: false),
                    equipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    servicioDetalle_sevicio_tpoId = table.Column<long>(type: "bigint", nullable: false),
                    servicio_sevicio_tpoId = table.Column<long>(type: "bigint", nullable: true),
                    ServicioDetalle_LugarCompra = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServicioDetalle_fechaCompra = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_servicioDetalle", x => x.servicioDetalle_id);
                    table.ForeignKey(
                        name: "FK_Tb_servicioDetalle_Tb_servicio_servicioDetalle_Servicio_id",
                        column: x => x.servicioDetalle_Servicio_id,
                        principalTable: "Tb_servicio",
                        principalColumn: "servicio_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tb_servicioDetalle_Tb_servicio_tpo_servicio_sevicio_tpoId",
                        column: x => x.servicio_sevicio_tpoId,
                        principalTable: "Tb_servicio_tpo",
                        principalColumn: "servicio_tpo_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tb_direccionCliente_direccionCliente_Cliente_Id",
                table: "Tb_direccionCliente",
                column: "direccionCliente_Cliente_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_servicio_servicio_cliente_id",
                table: "Tb_servicio",
                column: "servicio_cliente_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_servicio_Servicio_Tecnico_Id",
                table: "Tb_servicio",
                column: "Servicio_Tecnico_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_servicioDetalle_servicio_sevicio_tpoId",
                table: "Tb_servicioDetalle",
                column: "servicio_sevicio_tpoId");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_servicioDetalle_servicioDetalle_Servicio_id",
                table: "Tb_servicioDetalle",
                column: "servicioDetalle_Servicio_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tb_direccionCliente");

            migrationBuilder.DropTable(
                name: "Tb_servicioDetalle");

            migrationBuilder.DropTable(
                name: "Tb_servicio");

            migrationBuilder.DropTable(
                name: "Tb_servicio_tpo");

            migrationBuilder.DropTable(
                name: "Tb_tecnico");
        }
    }
}
