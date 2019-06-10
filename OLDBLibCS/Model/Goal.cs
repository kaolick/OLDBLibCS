using Newtonsoft.Json;

namespace OLDBLibCS.Model
{
    public class Goal
    {
        [JsonProperty("Comment")]
        public string Comment { get; set; }

        [JsonProperty("GoalGetterID")]
        public int GoalGetterId { get; set; }

        [JsonProperty("GoalGetterName")]
        public string GoalGetterName { get; set; }

        [JsonProperty("GoalID")]
        public int Id { get; set; }

        [JsonProperty("IsOvertime")]
        public bool IsOvertime { get; set; }

        [JsonProperty("IsOwnGoal")]
        public bool IsOwnGoal { get; set; }

        [JsonProperty("IsPenalty")]
        public bool IsPenalty { get; set; }

        [JsonProperty("MatchMinute")]
        public int MatchMinute { get; set; }

        [JsonProperty("ScoreTeam1")]
        public int ScoreTeam1 { get; set; }

        [JsonProperty("ScoreTeam2")]
        public int ScoreTeam2 { get; set; }
    }
}
