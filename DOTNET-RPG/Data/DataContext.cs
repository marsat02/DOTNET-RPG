﻿using Microsoft.EntityFrameworkCore;
using DOTNET_RPG.Models;

namespace DOTNET_RPG.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<Skill> Skills { get; set; }
        
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(user => user.Role).HasDefaultValue("Player");
            
            modelBuilder.Entity<Skill>().HasData(
                new Skill {Id = 1, Name = "Fireball", Damage = 30},
                new Skill {Id = 2, Name = "Frenzy", Damage = 20},
                new Skill {Id = 3, Name = "Blizzard", Damage = 50}
            );

            Utility.CreatePasswordHash("123456", out var passwordHasher, out var passwordSalt);

            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, PasswordHash = passwordHasher, PasswordSalt = passwordSalt, Username = "User1" },
                new User { Id = 2, PasswordHash = passwordHasher, PasswordSalt = passwordSalt, Username = "User2" }
            );

            modelBuilder.Entity<Character>().HasData(
                new Character {
                    Id = 1,
                    Name = "Frodo",
                    Class = RpgClass.Knight,
                    HitPoints = 100,
                    Strength = 15,
                    Defense = 10,
                    Intelligence = 10,
                    UserId = 1,
                },
                new Character {
                    Id = 2,
                    Name = "Raistlin",
                    Class = RpgClass.Mage,
                    HitPoints = 100,
                    Strength = 5,
                    Defense = 5,
                    Intelligence = 20,
                    UserId = 2,
                }
            );

            modelBuilder.Entity<Weapon>().HasData(
                new Weapon {Id = 1, Name = "The Master Sword", Damage = 20, CharacterId = 1},
                new Weapon {Id = 2, Name = "Crystal Wand", Damage = 5, CharacterId = 2}
            );
        }
    }
}