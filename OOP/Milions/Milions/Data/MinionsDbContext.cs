namespace Milions.Data
{
    using Microsoft.EntityFrameworkCore;
    using Milions.Models;

    public class MinionsDbContext:DbContext
    {
        private const string connectionString = "Database=Minions";
        public virtual DbSet<Milion> Milions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
