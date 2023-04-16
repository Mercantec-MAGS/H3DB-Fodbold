using Data.Configurations.Entities;
using FodboldDB_H3DB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;


namespace FodboldDB_H3DB.Data
{
    public class FodboldDBContext : DbContext
    {
        public DbSet<Coach> Coachs { get; set; }
        public DbSet<League> Leagues { get; set; }
        public DbSet<Match> Matchs { get; set; }
        public DbSet<Team> Teams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Database=FodboldDb;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LeagueConfiguration());
            modelBuilder.ApplyConfiguration(new TeamConfiguration());
            modelBuilder.ApplyConfiguration(new CoachConfiguration());

        }
    }
}
