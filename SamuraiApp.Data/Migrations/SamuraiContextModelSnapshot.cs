﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SamuraiApp.Data;

namespace SamuraiApp.Data.Migrations
{
    [DbContext(typeof(SamuraiContext))]
    partial class SamuraiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SamuraiApp.Domain.Battle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Battles");
                });

            modelBuilder.Entity("SamuraiApp.Domain.Clan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClanName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clans");
                });

            modelBuilder.Entity("SamuraiApp.Domain.Horse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SamuraiId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SamuraiId")
                        .IsUnique();

                    b.ToTable("Horses");
                });

            modelBuilder.Entity("SamuraiApp.Domain.Quote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SamuraiId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SamuraiId");

                    b.ToTable("Quotes");
                });

            modelBuilder.Entity("SamuraiApp.Domain.Samurai", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClanId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClanId");

                    b.ToTable("Samurais");
                });

            modelBuilder.Entity("SamuraiApp.Domain.SamuraiBattle", b =>
                {
                    b.Property<int>("SamuraiId")
                        .HasColumnType("int");

                    b.Property<int>("BattleId")
                        .HasColumnType("int");

                    b.HasKey("SamuraiId", "BattleId");

                    b.HasIndex("BattleId");

                    b.ToTable("SamuraiBattle");
                });

            modelBuilder.Entity("SamuraiApp.Domain.Horse", b =>
                {
                    b.HasOne("SamuraiApp.Domain.Samurai", null)
                        .WithOne("Horse")
                        .HasForeignKey("SamuraiApp.Domain.Horse", "SamuraiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SamuraiApp.Domain.Quote", b =>
                {
                    b.HasOne("SamuraiApp.Domain.Samurai", "Samurai")
                        .WithMany("Quotes")
                        .HasForeignKey("SamuraiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SamuraiApp.Domain.Samurai", b =>
                {
                    b.HasOne("SamuraiApp.Domain.Clan", "Clan")
                        .WithMany()
                        .HasForeignKey("ClanId");
                });

            modelBuilder.Entity("SamuraiApp.Domain.SamuraiBattle", b =>
                {
                    b.HasOne("SamuraiApp.Domain.Battle", "Battle")
                        .WithMany("SamuraiBattles")
                        .HasForeignKey("BattleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SamuraiApp.Domain.Samurai", "Samurai")
                        .WithMany("SamuraiBattles")
                        .HasForeignKey("SamuraiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
