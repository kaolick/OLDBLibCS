#nullable enable
using System.Text.Json.Serialization;

namespace OLDBLibCS.Model
{
    public class Location
    {
        [JsonPropertyName("locationID")]
        public int Id { get; set; }
        
        [JsonPropertyName("locationCity")]
        public string? City { get; set; }
        
        [JsonPropertyName("locationStadium")]
        public string? Stadium { get; set; }
    }
}
