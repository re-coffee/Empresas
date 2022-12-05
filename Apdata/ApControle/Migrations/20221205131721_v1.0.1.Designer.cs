﻿// <auto-generated />
using System;
using ApControle.Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApControle.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20221205131721_v1.0.1")]
    partial class v101
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ApControle.Classes.Configuracao", b =>
                {
                    b.Property<string>("Parametro")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Valor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Parametro");

                    b.ToTable("Configuracao");
                });

            modelBuilder.Entity("ApControle.Classes.Controle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit")
                        .HasColumnOrder(9);

                    b.Property<string>("Chamado")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(5);

                    b.Property<DateTime?>("DataCriacao")
                        .HasColumnType("datetime2")
                        .HasColumnOrder(10);

                    b.Property<DateTime?>("DataFim")
                        .HasColumnType("datetime2")
                        .HasColumnOrder(11);

                    b.Property<string>("Database")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(1);

                    b.Property<string>("Destinatarios")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(6);

                    b.Property<string>("IpServico")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(3);

                    b.Property<string>("PortaServico")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(4);

                    b.Property<string>("TamanhoBase")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(2);

                    b.Property<DateTime?>("UltimoLogin")
                        .HasColumnType("datetime2")
                        .HasColumnOrder(8);

                    b.Property<string>("UsuarioUltimoLogin")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(7);

                    b.HasKey("Id");

                    b.ToTable("Controle");
                });

            modelBuilder.Entity("ApControle.Classes.Email", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataEnvio")
                        .HasColumnType("datetime2");

                    b.Property<string>("Destinatarios")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdControle")
                        .HasColumnType("int");

                    b.Property<string>("TextoEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdControle");

                    b.ToTable("DisparosEmail");
                });

            modelBuilder.Entity("ApControle.Classes.Servidor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("AutenticaWindows")
                        .HasColumnType("bit");

                    b.Property<string>("Hostname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instancia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ip")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usuario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Servidor");
                });

            modelBuilder.Entity("ApControle.Classes.Email", b =>
                {
                    b.HasOne("ApControle.Classes.Controle", "ControleEnviado")
                        .WithMany("Emails")
                        .HasForeignKey("IdControle")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ControleEnviado");
                });

            modelBuilder.Entity("ApControle.Classes.Controle", b =>
                {
                    b.Navigation("Emails");
                });
#pragma warning restore 612, 618
        }
    }
}
