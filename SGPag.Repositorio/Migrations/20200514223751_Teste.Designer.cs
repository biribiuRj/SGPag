﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SGPag.Repositorio.Contexto;

namespace SGPag.Repositorio.Migrations
{
    [DbContext(typeof(SGPagContexto))]
    [Migration("20200514223751_Teste")]
    partial class Teste
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SGPag.Dominio.Entidades.Area", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AreaAtivo")
                        .HasColumnType("int");

                    b.Property<string>("AreaCurto")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("AreaLongo")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("Areas");
                });

            modelBuilder.Entity("SGPag.Dominio.Entidades.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<int>("EmpresaAtivo")
                        .HasColumnType("int");

                    b.Property<string>("EmpresaCurto")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("EmpresaLongo")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("Empresas");
                });

            modelBuilder.Entity("SGPag.Dominio.Entidades.Estado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("NomeEstado")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasMaxLength(5);

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("Estados");
                });

            modelBuilder.Entity("SGPag.Dominio.Entidades.Fornecedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Ativo");

                    b.Property<string>("Bairro");

                    b.Property<string>("CEP");

                    b.Property<string>("Cidade");

                    b.Property<int>("CodSap");

                    b.Property<string>("Complemento");

                    b.Property<string>("CpfCnpj");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Email");

                    b.Property<string>("EmailFinanceiro1");

                    b.Property<string>("EmailFinanceiro2");

                    b.Property<string>("EmailSocio1");

                    b.Property<string>("EmailSocio2");

                    b.Property<int>("EstadoId");

                    b.Property<string>("Identidade");

                    b.Property<string>("InscMunicipal");

                    b.Property<string>("Logradouro");

                    b.Property<string>("NomeCnpj");

                    b.Property<string>("NomeFinanceiro1");

                    b.Property<string>("NomeFinanceiro2");

                    b.Property<string>("NomeSap");

                    b.Property<string>("NomeSocio1");

                    b.Property<string>("NomeSocio2");

                    b.Property<string>("Numero");

                    b.Property<string>("Pais");

                    b.Property<string>("Telefone");

                    b.Property<string>("TelefoneFinanceiro1");

                    b.Property<string>("TelefoneFinanceiro2");

                    b.Property<string>("TelefoneSocio1");

                    b.Property<string>("TelefoneSocio2");

                    b.Property<string>("Terouraria");

                    b.Property<string>("TipoPessoa");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<int>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("EstadoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Fornecedores");
                });

            modelBuilder.Entity("SGPag.Dominio.Entidades.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime");

                    b.Property<string>("User")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("SGPag.Dominio.Entidades.Fornecedor", b =>
                {
                    b.HasOne("SGPag.Dominio.Entidades.Estado", "Estado")
                        .WithMany("Fornecedores")
                        .HasForeignKey("EstadoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SGPag.Dominio.Entidades.Usuario", "Usuario")
                        .WithMany("Fornecedores")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
