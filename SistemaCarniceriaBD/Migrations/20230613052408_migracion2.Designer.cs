﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaCarniceriaBD.Models;

#nullable disable

namespace SistemaCarniceriaBD.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230613052408_migracion2")]
    partial class migracion2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SistemaCarniceriaBD.Models.Compras", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.Property<int>("ProveedorId")
                        .HasColumnType("int");

                    b.Property<int>("cantidadCompra")
                        .HasColumnType("int");

                    b.Property<DateTime>("fechaCompra")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("totalCompra")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("id");

                    b.HasIndex("ProductoId");

                    b.HasIndex("ProveedorId");

                    b.ToTable("Compras");
                });

            modelBuilder.Entity("SistemaCarniceriaBD.Models.Login", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("UsuariosId")
                        .HasColumnType("int");

                    b.Property<string>("contraseña")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("usuario")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("id");

                    b.HasIndex("UsuariosId");

                    b.ToTable("Login");
                });

            modelBuilder.Entity("SistemaCarniceriaBD.Models.Productos", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("categoriaProducto")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("fechaEntrada")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fechaVencimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombreProducto")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<decimal>("precioProducto")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("id");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("SistemaCarniceriaBD.Models.Proveedores", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("correoElectrónico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dirección")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombreProveedor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("teléfono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Proveedores");
                });

            modelBuilder.Entity("SistemaCarniceriaBD.Models.Usuarios", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("apellidoUsuario")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("cedulaUsuario")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("clave")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("nombreUsuario")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("rol")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("usuario")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("SistemaCarniceriaBD.Models.Ventas", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.Property<int>("VendedorId")
                        .HasColumnType("int");

                    b.Property<int>("cantidadVenta")
                        .HasColumnType("int");

                    b.Property<DateTime>("fechaVenta")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("totalVenta")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("id");

                    b.HasIndex("ProductoId");

                    b.HasIndex("VendedorId");

                    b.ToTable("Ventas");
                });

            modelBuilder.Entity("SistemaCarniceriaBD.Models.Compras", b =>
                {
                    b.HasOne("SistemaCarniceriaBD.Models.Productos", "Producto")
                        .WithMany()
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaCarniceriaBD.Models.Proveedores", "Proveedor")
                        .WithMany()
                        .HasForeignKey("ProveedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Producto");

                    b.Navigation("Proveedor");
                });

            modelBuilder.Entity("SistemaCarniceriaBD.Models.Login", b =>
                {
                    b.HasOne("SistemaCarniceriaBD.Models.Usuarios", "Usuarios")
                        .WithMany()
                        .HasForeignKey("UsuariosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("SistemaCarniceriaBD.Models.Ventas", b =>
                {
                    b.HasOne("SistemaCarniceriaBD.Models.Productos", "Producto")
                        .WithMany()
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaCarniceriaBD.Models.Usuarios", "Vendedor")
                        .WithMany()
                        .HasForeignKey("VendedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Producto");

                    b.Navigation("Vendedor");
                });
#pragma warning restore 612, 618
        }
    }
}
