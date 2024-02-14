using System;
using Microsoft.EntityFrameworkCore;
using YtRunningClub.Models;

namespace YtRunningClub.Data
{
	public class ApplicationDbContext : DbContext
    {
        public DbSet<Race> Races { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=localhost;Port=3306;Database=RunGroups;Uid=root;Pwd=Monday225!";

            var serverVersion = new MySqlServerVersion(new Version(8, 3, 0));
            optionsBuilder.UseMySql(connectionString, serverVersion);
        }
    }
}

