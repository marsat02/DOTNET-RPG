﻿// <auto-generated />
using System;
using DOTNET_RPG.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DOTNET_RPG.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220107172317_FinalSeeding")]
    partial class FinalSeeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.13");

            modelBuilder.Entity("CharacterSkill", b =>
                {
                    b.Property<int>("CharactersId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SkillsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CharactersId", "SkillsId");

                    b.HasIndex("SkillsId");

                    b.ToTable("CharacterSkill");
                });

            modelBuilder.Entity("DOTNET_RPG.Models.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Class")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Defeats")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Defense")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Fights")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HitPoints")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Intelligence")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Strength")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Victories")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Characters");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Class = 0,
                            Defeats = 0,
                            Defense = 10,
                            Fights = 0,
                            HitPoints = 100,
                            Intelligence = 10,
                            Name = "Frodo",
                            Strength = 15,
                            UserId = 1,
                            Victories = 0
                        },
                        new
                        {
                            Id = 2,
                            Class = 1,
                            Defeats = 0,
                            Defense = 5,
                            Fights = 0,
                            HitPoints = 100,
                            Intelligence = 20,
                            Name = "Raistlin",
                            Strength = 5,
                            UserId = 2,
                            Victories = 0
                        });
                });

            modelBuilder.Entity("DOTNET_RPG.Models.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Damage")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Skills");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Damage = 30,
                            Name = "Fireball"
                        },
                        new
                        {
                            Id = 2,
                            Damage = 20,
                            Name = "Frenzy"
                        },
                        new
                        {
                            Id = 3,
                            Damage = 50,
                            Name = "Blizzard"
                        });
                });

            modelBuilder.Entity("DOTNET_RPG.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("BLOB");

                    b.Property<string>("Role")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue("Player");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PasswordHash = new byte[] { 18, 70, 153, 235, 35, 32, 62, 8, 233, 245, 251, 16, 40, 190, 243, 246, 53, 184, 254, 253, 213, 63, 129, 36, 199, 93, 98, 228, 144, 48, 107, 114, 69, 207, 10, 169, 92, 42, 220, 127, 34, 42, 162, 86, 59, 107, 139, 181, 145, 246, 56, 112, 32, 11, 145, 208, 114, 211, 28, 122, 146, 53, 235, 245 },
                            PasswordSalt = new byte[] { 209, 113, 171, 204, 151, 240, 239, 18, 41, 208, 129, 74, 27, 197, 151, 184, 103, 210, 18, 194, 0, 186, 162, 31, 51, 109, 1, 230, 151, 16, 57, 45, 39, 95, 217, 46, 123, 126, 147, 154, 112, 125, 12, 170, 247, 143, 245, 11, 112, 107, 86, 54, 150, 223, 229, 44, 245, 49, 104, 85, 211, 250, 159, 181, 171, 87, 226, 111, 204, 180, 221, 244, 189, 189, 179, 195, 29, 1, 40, 54, 70, 28, 36, 181, 29, 203, 138, 251, 240, 238, 227, 3, 238, 75, 82, 250, 218, 155, 221, 199, 39, 155, 232, 206, 113, 27, 200, 252, 26, 25, 213, 161, 146, 169, 104, 7, 193, 61, 32, 175, 84, 15, 77, 14, 234, 46, 173, 119 },
                            Username = "User1"
                        },
                        new
                        {
                            Id = 2,
                            PasswordHash = new byte[] { 18, 70, 153, 235, 35, 32, 62, 8, 233, 245, 251, 16, 40, 190, 243, 246, 53, 184, 254, 253, 213, 63, 129, 36, 199, 93, 98, 228, 144, 48, 107, 114, 69, 207, 10, 169, 92, 42, 220, 127, 34, 42, 162, 86, 59, 107, 139, 181, 145, 246, 56, 112, 32, 11, 145, 208, 114, 211, 28, 122, 146, 53, 235, 245 },
                            PasswordSalt = new byte[] { 209, 113, 171, 204, 151, 240, 239, 18, 41, 208, 129, 74, 27, 197, 151, 184, 103, 210, 18, 194, 0, 186, 162, 31, 51, 109, 1, 230, 151, 16, 57, 45, 39, 95, 217, 46, 123, 126, 147, 154, 112, 125, 12, 170, 247, 143, 245, 11, 112, 107, 86, 54, 150, 223, 229, 44, 245, 49, 104, 85, 211, 250, 159, 181, 171, 87, 226, 111, 204, 180, 221, 244, 189, 189, 179, 195, 29, 1, 40, 54, 70, 28, 36, 181, 29, 203, 138, 251, 240, 238, 227, 3, 238, 75, 82, 250, 218, 155, 221, 199, 39, 155, 232, 206, 113, 27, 200, 252, 26, 25, 213, 161, 146, 169, 104, 7, 193, 61, 32, 175, 84, 15, 77, 14, 234, 46, 173, 119 },
                            Username = "User2"
                        });
                });

            modelBuilder.Entity("DOTNET_RPG.Models.Weapon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CharacterId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Damage")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId")
                        .IsUnique();

                    b.ToTable("Weapons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CharacterId = 1,
                            Damage = 20,
                            Name = "The Master Sword"
                        },
                        new
                        {
                            Id = 2,
                            CharacterId = 2,
                            Damage = 5,
                            Name = "Crystal Wand"
                        });
                });

            modelBuilder.Entity("CharacterSkill", b =>
                {
                    b.HasOne("DOTNET_RPG.Models.Character", null)
                        .WithMany()
                        .HasForeignKey("CharactersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DOTNET_RPG.Models.Skill", null)
                        .WithMany()
                        .HasForeignKey("SkillsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DOTNET_RPG.Models.Character", b =>
                {
                    b.HasOne("DOTNET_RPG.Models.User", "User")
                        .WithMany("Characters")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DOTNET_RPG.Models.Weapon", b =>
                {
                    b.HasOne("DOTNET_RPG.Models.Character", "Character")
                        .WithOne("Weapon")
                        .HasForeignKey("DOTNET_RPG.Models.Weapon", "CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");
                });

            modelBuilder.Entity("DOTNET_RPG.Models.Character", b =>
                {
                    b.Navigation("Weapon");
                });

            modelBuilder.Entity("DOTNET_RPG.Models.User", b =>
                {
                    b.Navigation("Characters");
                });
#pragma warning restore 612, 618
        }
    }
}