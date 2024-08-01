using Microsoft.EntityFrameworkCore;
using StarWarsAPI.Models;

namespace StarWarsAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Starship> Starships { get; set; }
    }
}
