using System.Text.Json.Serialization;

namespace OLDBLibCS.Model
{
    public class Location
    {
        [JsonPropertyName("locationCity")]
        public string City { get; set; }

        [JsonPropertyName("locationID")]
        public int Id { get; set; }

        [JsonPropertyName("locationStadium")]
        public string Stadium { get; set; }
    }
}
