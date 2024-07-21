using System.Text.Json.Serialization;

namespace OLDBLibCS.Model
{
    public class MatchResult
    {
        [JsonPropertyName("resultDescription")]
        public string Description { get; set; }

        [JsonPropertyName("resultID")]
        public int Id { get; set; }

        [JsonPropertyName("resultName")]
        public string Name { get; set; }

        [JsonPropertyName("resultOrderID")]
        public int OrderId { get; set; }

        [JsonPropertyName("pointsTeam1")]
        public int? PointsTeam1 { get; set; }

        [JsonPropertyName("pointsTeam2")]
        public int? PointsTeam2 { get; set; }

        [JsonPropertyName("resultTypeID")]
        public int TypeId { get; set; }
    }
}
