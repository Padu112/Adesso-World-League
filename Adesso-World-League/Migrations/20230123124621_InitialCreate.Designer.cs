﻿// <auto-generated />
using System;
using Adesso_World_League.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AdessoWorldLeague.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230123124621_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.2");

            modelBuilder.Entity("Adesso_World_League.Entities.Countries", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Adesso_World_League.Entities.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CountriesId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CountriesId");

                    b.ToTable("Team");
                });

            modelBuilder.Entity("Adesso_World_League.Entities.Team", b =>
                {
                    b.HasOne("Adesso_World_League.Entities.Countries", null)
                        .WithMany("Team")
                        .HasForeignKey("CountriesId");
                });

            modelBuilder.Entity("Adesso_World_League.Entities.Countries", b =>
                {
                    b.Navigation("Team");
                });
#pragma warning restore 612, 618
        }
    }
}
