using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using StarWarsAPI.Models;

namespace StarWarsAPI.Services
{
    public class StarshipService
    {
        private readonly HttpClient _httpClient;

        public StarshipService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Starship>> GetStarshipsAsync()
        {
            var response = await _httpClient.GetAsync("starships/");
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            var starshipResponse = JsonSerializer.Deserialize<StarshipResponse>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            return starshipResponse?.Results ?? new List<Starship>();
        }
    }

    public class StarshipResponse
    {
        public int Count { get; set; }
        public string? Next { get; set; }
        public string? Previous { get; set; }
        public List<Starship>? Results { get; set; }
    }
}
