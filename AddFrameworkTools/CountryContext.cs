using Microsoft.EntityFrameworkCore;
using RazorCountry.Models;

namespace RazorCountry.Data
{
    public class CountryContext : DbContext
    {
        public CountryContext(DbContextOptions<CountryContext> options)
                : base(options)
        {
        }
        public DbSet<Continent> Continents { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Continent>().ToTable("Continent");
            modelBuilder.Entity<Country>().ToTable("Country");
        }
    }
}