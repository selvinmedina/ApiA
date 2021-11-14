﻿// <auto-generated />
using System;
using ApiA.Infraestructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApiA.Migrations
{
    [DbContext(typeof(EcommerceContext))]
    [Migration("20211114013900_DBInit")]
    partial class DBInit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ApiA.Infraestructure.Entities.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Comentario")
                        .HasColumnType("text");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("ApiA.Infraestructure.Entities.PedidoDetalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("PedidoId")
                        .HasColumnType("int");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.Property<decimal>("SubTotal")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("Id");

                    b.HasIndex("PedidoId");

                    b.ToTable("PedidoDetalle");
                });

            modelBuilder.Entity("ApiA.Infraestructure.Entities.PedidoDetalle", b =>
                {
                    b.HasOne("ApiA.Infraestructure.Entities.Pedido", "Pedido")
                        .WithMany("PedidoDetalles")
                        .HasForeignKey("PedidoId")
                        .HasConstraintName("FK_Pedido_DetallePedido")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}