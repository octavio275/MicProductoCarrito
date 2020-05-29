﻿// <auto-generated />
using CapaAccesoDatos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CapaAccesoDatos.Migrations
{
    [DbContext(typeof(ClassContexto))]
    [Migration("20200522040516_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0-preview.4.20220.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CapaDominio.Entidades.Carrito", b =>
                {
                    b.Property<int>("CarritoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteID")
                        .HasColumnType("int");

                    b.Property<int>("ValorID")
                        .HasColumnType("int");

                    b.HasKey("CarritoID");

                    b.ToTable("carrito");
                });

            modelBuilder.Entity("CapaDominio.Entidades.ProductoCarrito", b =>
                {
                    b.Property<int>("ProductoCarritoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CarritoID")
                        .HasColumnType("int");

                    b.Property<int>("ProductoID")
                        .HasColumnType("int");

                    b.HasKey("ProductoCarritoID");

                    b.HasIndex("CarritoID");

                    b.ToTable("CarritoProducto");
                });

            modelBuilder.Entity("CapaDominio.Entidades.ProductoCarrito", b =>
                {
                    b.HasOne("CapaDominio.Entidades.Carrito", "CarritoNavigator")
                        .WithMany()
                        .HasForeignKey("CarritoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
