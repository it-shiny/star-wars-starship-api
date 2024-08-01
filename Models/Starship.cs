using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace StarWarsAPI.Models
{
    public class Starship
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        public string? Name { get; set; }

        [MaxLength(100)]
        public string? Model { get; set; }

        [MaxLength(100)]
        public string? Manufacturer { get; set; }

        [MaxLength(50)]
        [JsonPropertyName("cost_in_credits")]
        public string? CostInCredits { get; set; }

        [MaxLength(50)]
        public string? Length { get; set; }

        [MaxLength(50)]
        [JsonPropertyName("max_atmosphering_speed")]
        public string? MaxAtmospheringSpeed { get; set; }

        [MaxLength(50)]
        public string? Crew { get; set; }

        [MaxLength(50)]
        public string? Passengers { get; set; }

        [MaxLength(50)]
        [JsonPropertyName("cargo_capacity")]
        public string? CargoCapacity { get; set; }

        [MaxLength(100)]
        public string? Consumables { get; set; }

        [MaxLength(50)]
        [JsonPropertyName("hyperdrive_rating")]
        public string? HyperdriveRating { get; set; }

        [MaxLength(50)]
        public string? MGLT { get; set; }

        [MaxLength(50)]
        [JsonPropertyName("starship_class")]
        public string? StarshipClass { get; set; }

        // Nullable properties for non-essential data
        [JsonPropertyName("pilots")]
        public List<string>? Pilots { get; set; }

        [JsonPropertyName("films")]
        public List<string>? Films { get; set; }

        [JsonPropertyName("created")]
        public string? Created { get; set; }

        [JsonPropertyName("edited")]
        public string? Edited { get; set; }

        [JsonPropertyName("url")]
        public string? Url { get; set; }
    }
}
