using CharacterCart.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterCart.DAL.EfStructures
{
    public class CharacterCartContext : DbContext
    {
        public CharacterCartContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Character> Characters { get; set; }
        public DbSet<CharacterRaces> CharacterRaces { get; set; }
        public DbSet<Classes> Classes { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Weapons> Weapons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Classes>(entity =>
            {
                entity.Property(e => e.IsArcaneCaster).HasColumnType("bit").HasDefaultValue(false);
                entity.Property(e => e.IsDivineCaster).HasColumnType("bit").HasDefaultValue(false);
            });

            modelBuilder.Entity<Weapons>(entity =>
            {
                entity.Property(e => e.IsRanged).HasColumnType("bit").HasDefaultValue(false);
            });

        }
    }
}
