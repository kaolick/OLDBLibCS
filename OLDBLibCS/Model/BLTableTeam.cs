using System.Text.Json.Serialization;

namespace OLDBLibCS.Model
{
    public class BlTableTeam
    {
        [JsonPropertyName("draw")]
        public int Draw { get; set; }

        [JsonPropertyName("goalDiff")]
        public int GoalDiff { get; set; }

        [JsonPropertyName("goals")]
        public int Goals { get; set; }

        [JsonPropertyName("teamIconUrl")]
        public string IconUrl { get; set; }

        [JsonPropertyName("teamInfoId")]
        public int InfoId { get; set; }

        [JsonPropertyName("lost")]
        public int Lost { get; set; }

        [JsonPropertyName("matches")]
        public int Matches { get; set; }

        [JsonPropertyName("teamName")]
        public string Name { get; set; }

        [JsonPropertyName("opponentGoals")]
        public int OpponentGoals { get; set; }

        [JsonPropertyName("points")]
        public int Points { get; set; }

        [JsonPropertyName("shortName")]
        public string ShortName { get; set; }

        [JsonPropertyName("won")]
        public int Won { get; set; }
    }
}
