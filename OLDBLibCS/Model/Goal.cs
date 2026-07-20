#nullable enable
using System.Text.Json.Serialization;

namespace OLDBLibCS.Model
{
    public class Goal
    {
        [JsonPropertyName("goalID")]
        public int Id { get; set; }
        
        [JsonPropertyName("scoreTeam1")]
        public int? ScoreTeam1 { get; set; }

        [JsonPropertyName("scoreTeam2")]
        public int? ScoreTeam2 { get; set; }
        
        [JsonPropertyName("matchMinute")]
        public int? MatchMinute { get; set; }
        
        [JsonPropertyName("goalGetterID")]
        public int GoalGetterId { get; set; }
        
        [JsonPropertyName("goalGetterName")]
        public string? GoalGetterName { get; set; }
        
        [JsonPropertyName("scoringTeamId")]
        public int? ScoringTeamId { get; set; }
        
        [JsonPropertyName("isPenalty")]
        public bool? IsPenalty { get; set; }
        
        [JsonPropertyName("isOwnGoal")]
        public bool? IsOwnGoal { get; set; }
        
        [JsonPropertyName("isOvertime")]
        public bool? IsOvertime { get; set; }
        
        [JsonPropertyName("comment")]
        public string? Comment { get; set; }
    }
}
