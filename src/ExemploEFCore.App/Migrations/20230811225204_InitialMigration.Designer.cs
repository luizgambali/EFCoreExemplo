﻿// <auto-generated />
using ExemploEFCore.App.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ExemploEFCore.App.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230811225204_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.10");

            modelBuilder.Entity("ExemploEFCore.App.Models.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar2")
                        .HasColumnName("Email");

                    b.Property<int>("Idade")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(0)
                        .HasColumnName("Idade");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar2")
                        .HasColumnName("Nome");

                    b.HasKey("Id");

                    b.ToTable("Alunos", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
