using Adesso_World_League.Entities;
using Microsoft.EntityFrameworkCore;

namespace Adesso_World_League.Helpers
{
    public class DataContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(Configuration.GetConnectionString("WebApiDatabase"));
        }

        public DbSet<Countries> Countries { get; set; }
        public DbSet<Team> Team { get; set; }
        public DbSet<SavedGroups> SavedGroups { get; set; }
    }
}