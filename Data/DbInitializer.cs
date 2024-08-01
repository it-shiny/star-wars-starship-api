using System.Threading.Tasks;
using StarWarsAPI.Models;
using StarWarsAPI.Services;

namespace StarWarsAPI.Data
{
    public static class DbInitializer
    {
        public static async Task Initialize(ApplicationDbContext context, StarshipService starshipService)
        {
            context.Database.EnsureCreated();

            // Look for any starships.
            if (context.Starships.Any())
            {
                return;   // DB has been seeded
            }

            var starships = await starshipService.GetStarshipsAsync();

            foreach (var starship in starships)
            {
                context.Starships.Add(starship);
            }

            await context.SaveChangesAsync();
        }
    }
}
