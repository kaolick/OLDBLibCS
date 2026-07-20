#nullable enable
using System.Text.Json.Serialization;

namespace OLDBLibCS.Model
{
    public class BlTableTeam
    {
        [JsonPropertyName("teamInfoId")]
        public int InfoId { get; set; }
        
        [JsonPropertyName("teamName")]
        public string? Name { get; set; }

        [JsonPropertyName("shortName")]
        public string? ShortName { get; set; }
        
        [JsonPropertyName("teamIconUrl")]
        public string? IconUrl { get; set; }

        [JsonPropertyName("points")]
        public int Points { get; set; }
        
        [JsonPropertyName("opponentGoals")]
        public int OpponentGoals { get; set; }
        
        [JsonPropertyName("goals")]
        public int Goals { get; set; }
        
        [JsonPropertyName("matches")]
        public int Matches { get; set; }
        
        [JsonPropertyName("won")]
        public int Won { get; set; }
        
        [JsonPropertyName("lost")]
        public int Lost { get; set; }
        
        [JsonPropertyName("draw")]
        public int Draw { get; set; }

        [JsonPropertyName("goalDiff")]
        public int GoalDiff { get; set; }
    }
}
