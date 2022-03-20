using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;

namespace Entities
{
    public class FootballContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\MSSQLLocalDB;Database=FootballDb;Trusted_Connection=True;");
        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }

        public DbSet<PlayerAdress> PlayerAdresses { get; set; }
        public DbSet<Sponsor> Sponsors { get; set; }
        public DbSet<Country> Countries { get; set; }
    }
}