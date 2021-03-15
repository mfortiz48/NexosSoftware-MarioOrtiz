﻿// <auto-generated />
using System;
using Mario_Ortiz_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Mario_Ortiz_API.Migrations
{
    [DbContext(typeof(_DbContex))]
    [Migration("20210314211935_SegundaMigracion")]
    partial class SegundaMigracion
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Mario_Ortiz_API.Models.Tb_Autor", b =>
                {
                    b.Property<long>("autor_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("autor_Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("autor_ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("autor_fechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("autor_nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("autor_id");

                    b.ToTable("Tb_autores");
                });

            modelBuilder.Entity("Mario_Ortiz_API.Models.Tb_Editorial", b =>
                {
                    b.Property<long>("Editorial_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Editorial_Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Editorial_Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Editorial_email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Editorial_librosRegistrados")
                        .HasColumnType("int");

                    b.Property<string>("Editorial_nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Editorial_id");

                    b.ToTable("Tb_editoriales");
                });

            modelBuilder.Entity("Mario_Ortiz_API.Models.Tb_Libro", b =>
                {
                    b.Property<long>("libro_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("Libro_Autor")
                        .HasColumnType("bigint");

                    b.Property<long>("Libro_Editorial")
                        .HasColumnType("bigint");

                    b.Property<int>("libro_NumeroPaginas")
                        .HasColumnType("int");

                    b.Property<int>("libro_año")
                        .HasColumnType("int");

                    b.Property<string>("libro_genero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("libro_titulo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("libro_Id");

                    b.HasIndex("Libro_Autor");

                    b.HasIndex("Libro_Editorial");

                    b.ToTable("Tb_libros");
                });

            modelBuilder.Entity("Mario_Ortiz_API.Models.Tb_Libro", b =>
                {
                    b.HasOne("Mario_Ortiz_API.Models.Tb_Autor", "Autores")
                        .WithMany()
                        .HasForeignKey("Libro_Autor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mario_Ortiz_API.Models.Tb_Editorial", "Editoriales")
                        .WithMany()
                        .HasForeignKey("Libro_Editorial")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Autores");

                    b.Navigation("Editoriales");
                });
#pragma warning restore 612, 618
        }
    }
}
