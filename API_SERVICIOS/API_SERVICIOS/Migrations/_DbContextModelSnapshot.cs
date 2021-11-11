﻿// <auto-generated />
using System;
using API_SERVICIOS.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API_SERVICIOS.Migrations
{
    [DbContext(typeof(_DbContext))]
    partial class _DbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("API_SERVICIOS.Model.tb_cargue", b =>
                {
                    b.Property<long>("cliente_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("cargue_anio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cargue_apr_cartera")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cargue_barrio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cargue_carta_garantia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cargue_cedula")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cargue_ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cargue_cod_postal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cargue_cod_servicio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cargue_cod_vendedor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cargue_consecutivo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cargue_cta_cliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cargue_direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cargue_email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cargue_equipo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cargue_est_orden")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cargue_factura")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cargue_factura_2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cargue_fec_atencion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cargue_fec_compra")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cargue_fec_pago")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cargue_fec_reporte")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cargue_incidencia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cargue_lugar_compra")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cargue_mes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cargue_nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cargue_observaciones")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cargue_pago")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cargue_ref_pago")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cargue_rer_armado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cargue_serv_solic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cargue_tecnico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cargue_tel_fijo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cargue_tel_mov")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("cliente_id");

                    b.ToTable("Tb_Cargues");
                });

            modelBuilder.Entity("API_SERVICIOS.Model.tb_clientes", b =>
                {
                    b.Property<long>("cliente_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("cliente_direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cliente_dni")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cliente_email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cliente_nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cliente_tel_fjo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cliente_tel_mov")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cliente_tpo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("cliente_id");

                    b.ToTable("Tb_Clientes");
                });

            modelBuilder.Entity("API_SERVICIOS.Model.tb_direccionCliente", b =>
                {
                    b.Property<long>("direccionCliente_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("direccionCliente_Cliente_Id")
                        .HasColumnType("bigint");

                    b.Property<string>("direccionCliente_Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccionCliente_coordenada_x")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccionCliente_coordenada_y")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccionCliente_estado")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("direccionCliente_id");

                    b.HasIndex("direccionCliente_Cliente_Id");

                    b.ToTable("Tb_direccionCliente");
                });

            modelBuilder.Entity("API_SERVICIOS.Model.tb_servicio", b =>
                {
                    b.Property<long>("servicio_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Servicio_Observacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Servicio_Tecnico_Id")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("servicio_Fecha_gestion")
                        .HasColumnType("datetime2");

                    b.Property<long>("servicio_cliente_id")
                        .HasColumnType("bigint");

                    b.Property<long>("servicio_consecutivo")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("servicio_fechaApertura")
                        .HasColumnType("datetime2");

                    b.HasKey("servicio_id");

                    b.HasIndex("Servicio_Tecnico_Id");

                    b.HasIndex("servicio_cliente_id");

                    b.ToTable("Tb_servicio");
                });

            modelBuilder.Entity("API_SERVICIOS.Model.tb_servicioDetalle", b =>
                {
                    b.Property<long>("servicioDetalle_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ServicioDetalle_LugarCompra")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServicioDetalle_fechaCompra")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("equipo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("servicioDetalle_Servicio_id")
                        .HasColumnType("bigint");

                    b.Property<long>("servicioDetalle_sevicio_tpoId")
                        .HasColumnType("bigint");

                    b.Property<long?>("servicio_sevicio_tpoId")
                        .HasColumnType("bigint");

                    b.HasKey("servicioDetalle_id");

                    b.HasIndex("servicioDetalle_Servicio_id");

                    b.HasIndex("servicio_sevicio_tpoId");

                    b.ToTable("Tb_servicioDetalle");
                });

            modelBuilder.Entity("API_SERVICIOS.Model.tb_servicio_tpo", b =>
                {
                    b.Property<long>("servicio_tpo_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("servicio_tpo_cod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("servicio_tpo_descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("servicio_tpo_estado")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("servicio_tpo_id");

                    b.ToTable("Tb_servicio_tpo");
                });

            modelBuilder.Entity("API_SERVICIOS.Model.tb_tecnico", b =>
                {
                    b.Property<long>("tecnico_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("tecnico_direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tecnico_dni")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tecnico_email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tecnico_estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tecnico_nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("tecnico_id");

                    b.ToTable("Tb_tecnico");
                });

            modelBuilder.Entity("API_SERVICIOS.Model.tb_direccionCliente", b =>
                {
                    b.HasOne("API_SERVICIOS.Model.tb_clientes", "Clientes")
                        .WithMany()
                        .HasForeignKey("direccionCliente_Cliente_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clientes");
                });

            modelBuilder.Entity("API_SERVICIOS.Model.tb_servicio", b =>
                {
                    b.HasOne("API_SERVICIOS.Model.tb_tecnico", "Tecnicos")
                        .WithMany()
                        .HasForeignKey("Servicio_Tecnico_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API_SERVICIOS.Model.tb_clientes", "Clientes")
                        .WithMany()
                        .HasForeignKey("servicio_cliente_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clientes");

                    b.Navigation("Tecnicos");
                });

            modelBuilder.Entity("API_SERVICIOS.Model.tb_servicioDetalle", b =>
                {
                    b.HasOne("API_SERVICIOS.Model.tb_servicio", "Servicio")
                        .WithMany()
                        .HasForeignKey("servicioDetalle_Servicio_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API_SERVICIOS.Model.tb_servicio_tpo", "Servicio_tipo")
                        .WithMany()
                        .HasForeignKey("servicio_sevicio_tpoId");

                    b.Navigation("Servicio");

                    b.Navigation("Servicio_tipo");
                });
#pragma warning restore 612, 618
        }
    }
}
