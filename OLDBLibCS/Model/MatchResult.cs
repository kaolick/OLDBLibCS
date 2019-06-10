using Newtonsoft.Json;

namespace OLDBLibCS.Model
{
    public class MatchResult
    {
        [JsonProperty("ResultDescription")]
        public string Description { get; set; }

        [JsonProperty("ResultID")]
        public int Id { get; set; }

        [JsonProperty("ResultName")]
        public string Name { get; set; }

        [JsonProperty("ResultOrderID")]
        public int OrderId { get; set; }

        [JsonProperty("PointsTeam1")]
        public int PointsTeam1 { get; set; }

        [JsonProperty("PointsTeam2")]
        public int PointsTeam2 { get; set; }

        [JsonProperty("ResultTypeID")]
        public int TypeId { get; set; }
    }
}
