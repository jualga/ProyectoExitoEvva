﻿// <auto-generated />
using System;
using Exito.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Exito.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20210922160848_ini")]
    partial class ini
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Exito.App.Dominio.Compra", b =>
                {
                    b.Property<int>("CompraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("EmpleadoId")
                        .HasColumnType("int");

                    b.Property<string>("Fecha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Finalizada")
                        .HasColumnType("bit");

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.HasKey("CompraId");

                    b.HasIndex("EmpleadoId");

                    b.ToTable("Compras");
                });

            modelBuilder.Entity("Exito.App.Dominio.CompraDetalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("CompraId")
                        .HasColumnType("int");

                    b.Property<int>("ConsolaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompraId");

                    b.HasIndex("ConsolaId");

                    b.ToTable("CompraDetalles");
                });

            modelBuilder.Entity("Exito.App.Dominio.Consola", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Almacenamiento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ControlId")
                        .HasColumnType("int");

                    b.Property<string>("Fabricante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypoDisco")
                        .HasColumnType("int");

                    b.Property<string>("VelocidadProcesamiento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VelocidadRam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Version")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("precioCompra")
                        .HasColumnType("int");

                    b.Property<int>("precioVenta")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ControlId");

                    b.ToTable("Consolas");
                });

            modelBuilder.Entity("Exito.App.Dominio.Control", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<string>("Fabricante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Version")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("precioCompra")
                        .HasColumnType("int");

                    b.Property<int>("precioVenta")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Controles");
                });

            modelBuilder.Entity("Exito.App.Dominio.Empleado", b =>
                {
                    b.Property<int>("EmpleadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cedula")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Clave")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RolId")
                        .HasColumnType("int");

                    b.Property<int>("SucursalId")
                        .HasColumnType("int");

                    b.Property<string>("Usuario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmpleadoId");

                    b.HasIndex("RolId");

                    b.HasIndex("SucursalId");

                    b.ToTable("Empleados");
                });

            modelBuilder.Entity("Exito.App.Dominio.Rol", b =>
                {
                    b.Property<int>("RolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RolId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Exito.App.Dominio.Sucursal", b =>
                {
                    b.Property<int>("SucursalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SucursalId");

                    b.ToTable("Sucursales");
                });

            modelBuilder.Entity("Exito.App.Dominio.Venta", b =>
                {
                    b.Property<int>("VentaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("EmpleadoId")
                        .HasColumnType("int");

                    b.Property<string>("Fecha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Finalizada")
                        .HasColumnType("bit");

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.HasKey("VentaID");

                    b.HasIndex("EmpleadoId");

                    b.ToTable("Ventas");
                });

            modelBuilder.Entity("Exito.App.Dominio.VentaDetalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("ConsolaId")
                        .HasColumnType("int");

                    b.Property<int>("VentaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ConsolaId");

                    b.HasIndex("VentaId");

                    b.ToTable("VentaDetalles");
                });

            modelBuilder.Entity("Exito.App.Dominio.VideoJuego", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("ConsolaId")
                        .HasColumnType("int");

                    b.Property<string>("Fabricante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Version")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("precioCompra")
                        .HasColumnType("int");

                    b.Property<int>("precioVenta")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ConsolaId");

                    b.ToTable("VideoJuegos");
                });

            modelBuilder.Entity("Exito.App.Dominio.Compra", b =>
                {
                    b.HasOne("Exito.App.Dominio.Empleado", "Empleado")
                        .WithMany()
                        .HasForeignKey("EmpleadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empleado");
                });

            modelBuilder.Entity("Exito.App.Dominio.CompraDetalle", b =>
                {
                    b.HasOne("Exito.App.Dominio.Compra", "Compra")
                        .WithMany()
                        .HasForeignKey("CompraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Exito.App.Dominio.Consola", "Consola")
                        .WithMany()
                        .HasForeignKey("ConsolaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Compra");

                    b.Navigation("Consola");
                });

            modelBuilder.Entity("Exito.App.Dominio.Consola", b =>
                {
                    b.HasOne("Exito.App.Dominio.Control", "Controles")
                        .WithMany()
                        .HasForeignKey("ControlId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Controles");
                });

            modelBuilder.Entity("Exito.App.Dominio.Empleado", b =>
                {
                    b.HasOne("Exito.App.Dominio.Rol", "Rol")
                        .WithMany()
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Exito.App.Dominio.Sucursal", "Sucursal")
                        .WithMany()
                        .HasForeignKey("SucursalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rol");

                    b.Navigation("Sucursal");
                });

            modelBuilder.Entity("Exito.App.Dominio.Venta", b =>
                {
                    b.HasOne("Exito.App.Dominio.Empleado", "Empleado")
                        .WithMany()
                        .HasForeignKey("EmpleadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empleado");
                });

            modelBuilder.Entity("Exito.App.Dominio.VentaDetalle", b =>
                {
                    b.HasOne("Exito.App.Dominio.Consola", "Consola")
                        .WithMany()
                        .HasForeignKey("ConsolaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Exito.App.Dominio.Venta", "Venta")
                        .WithMany()
                        .HasForeignKey("VentaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Consola");

                    b.Navigation("Venta");
                });

            modelBuilder.Entity("Exito.App.Dominio.VideoJuego", b =>
                {
                    b.HasOne("Exito.App.Dominio.Consola", "Consola")
                        .WithMany()
                        .HasForeignKey("ConsolaId");

                    b.Navigation("Consola");
                });
#pragma warning restore 612, 618
        }
    }
}
