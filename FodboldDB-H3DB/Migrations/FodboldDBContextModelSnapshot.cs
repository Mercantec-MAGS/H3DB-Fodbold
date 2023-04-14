﻿// <auto-generated />
using System;
using FodboldDB_H3DB.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FodboldDB_H3DB.Migrations
{
    [DbContext(typeof(FodboldDBContext))]
    partial class FodboldDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FodboldDB_H3DB.Models.Coach", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeamId")
                        .IsUnique()
                        .HasFilter("[TeamId] IS NOT NULL");

                    b.HasIndex("Name", "TeamId")
                        .IsUnique()
                        .HasFilter("[TeamId] IS NOT NULL");

                    b.ToTable("Coachs");

                    b.HasData(
                        new
                        {
                            Id = 20,
                            Name = "Coach1",
                            TeamId = 20
                        },
                        new
                        {
                            Id = 21,
                            Name = "Coach2",
                            TeamId = 21
                        },
                        new
                        {
                            Id = 22,
                            Name = "Coach3",
                            TeamId = 22
                        });
                });

            modelBuilder.Entity("FodboldDB_H3DB.Models.League", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AgeGroup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LeagueId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Leagues");

                    b.HasData(
                        new
                        {
                            Id = 20,
                            Name = "League 1"
                        });
                });

            modelBuilder.Entity("FodboldDB_H3DB.Models.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AwayTeamId")
                        .HasColumnType("int");

                    b.Property<int>("HomeTeamId")
                        .HasColumnType("int");

                    b.Property<int?>("LeagueId")
                        .HasColumnType("int");

                    b.Property<DateTime>("MatchEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("MatchStart")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Winner")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AwayTeamId");

                    b.HasIndex("HomeTeamId");

                    b.HasIndex("LeagueId");

                    b.ToTable("Matchs");
                });

            modelBuilder.Entity("FodboldDB_H3DB.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("LeagueId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LeagueId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            Id = 20,
                            Name = "Team 1"
                        },
                        new
                        {
                            Id = 21,
                            Name = "Team 2"
                        },
                        new
                        {
                            Id = 22,
                            Name = "Team 3"
                        });
                });

            modelBuilder.Entity("FodboldDB_H3DB.Models.Coach", b =>
                {
                    b.HasOne("FodboldDB_H3DB.Models.Team", "Team")
                        .WithOne("Coach")
                        .HasForeignKey("FodboldDB_H3DB.Models.Coach", "TeamId");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("FodboldDB_H3DB.Models.Match", b =>
                {
                    b.HasOne("FodboldDB_H3DB.Models.Team", "AwayTeam")
                        .WithMany()
                        .HasForeignKey("AwayTeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FodboldDB_H3DB.Models.Team", "HomeTeam")
                        .WithMany()
                        .HasForeignKey("HomeTeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FodboldDB_H3DB.Models.League", null)
                        .WithMany("Matches")
                        .HasForeignKey("LeagueId");

                    b.Navigation("AwayTeam");

                    b.Navigation("HomeTeam");
                });

            modelBuilder.Entity("FodboldDB_H3DB.Models.Team", b =>
                {
                    b.HasOne("FodboldDB_H3DB.Models.League", "League")
                        .WithMany()
                        .HasForeignKey("LeagueId");

                    b.Navigation("League");
                });

            modelBuilder.Entity("FodboldDB_H3DB.Models.League", b =>
                {
                    b.Navigation("Matches");
                });

            modelBuilder.Entity("FodboldDB_H3DB.Models.Team", b =>
                {
                    b.Navigation("Coach")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
