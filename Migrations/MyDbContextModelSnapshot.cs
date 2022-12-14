// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using UsuarioEx.Models;

#nullable disable

namespace UsuarioEx.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("UsuarioEx.Models.Pessoas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Pessoas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Pessoas");
                });

            modelBuilder.Entity("UsuarioEx.Models.Turmas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Ano")
                        .HasColumnType("integer");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Turmas");
                });

            modelBuilder.Entity("UsuarioEx.Models.Alunos", b =>
                {
                    b.HasBaseType("UsuarioEx.Models.Pessoas");

                    b.Property<string>("DataNascimento")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("TurmasId")
                        .HasColumnType("integer");

                    b.HasIndex("TurmasId");

                    b.HasDiscriminator().HasValue("Alunos");
                });

            modelBuilder.Entity("UsuarioEx.Models.Professores", b =>
                {
                    b.HasBaseType("UsuarioEx.Models.Pessoas");

                    b.Property<double>("Formação")
                        .HasColumnType("double precision");

                    b.Property<string>("Salario")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("TurmasId")
                        .HasColumnType("integer")
                        .HasColumnName("Professores_TurmasId");

                    b.HasIndex("TurmasId");

                    b.HasDiscriminator().HasValue("Professores");
                });

            modelBuilder.Entity("UsuarioEx.Models.Disciplinas", b =>
                {
                    b.HasBaseType("UsuarioEx.Models.Professores");

                    b.Property<string>("Cargahoraria")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("TurmasId1")
                        .HasColumnType("integer");

                    b.HasIndex("TurmasId1");

                    b.HasDiscriminator().HasValue("Disciplinas");
                });

            modelBuilder.Entity("UsuarioEx.Models.Alunos", b =>
                {
                    b.HasOne("UsuarioEx.Models.Turmas", "Turmas")
                        .WithMany("Alunos")
                        .HasForeignKey("TurmasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Turmas");
                });

            modelBuilder.Entity("UsuarioEx.Models.Professores", b =>
                {
                    b.HasOne("UsuarioEx.Models.Turmas", "Turmas")
                        .WithMany("Professores")
                        .HasForeignKey("TurmasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Turmas");
                });

            modelBuilder.Entity("UsuarioEx.Models.Disciplinas", b =>
                {
                    b.HasOne("UsuarioEx.Models.Turmas", null)
                        .WithMany("Disciplinas")
                        .HasForeignKey("TurmasId1");
                });

            modelBuilder.Entity("UsuarioEx.Models.Turmas", b =>
                {
                    b.Navigation("Alunos");

                    b.Navigation("Disciplinas");

                    b.Navigation("Professores");
                });
#pragma warning restore 612, 618
        }
    }
}
