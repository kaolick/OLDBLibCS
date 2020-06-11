using Newtonsoft.Json;

namespace OLDBLibCS.Model
{
    public class BLTableTeam
    {
        [JsonProperty("Draw")]
        public int Draw { get; set; }

        [JsonProperty("GoalDiff")]
        public int GoalDiff { get; set; }

        [JsonProperty("Goals")]
        public int Goals { get; set; }

        [JsonProperty("TeamIconUrl")]
        public string IconUrl { get; set; }

        [JsonProperty("TeamInfoId")]
        public int InfoId { get; set; }

        [JsonProperty("Lost")]
        public int Lost { get; set; }

        [JsonProperty("Matches")]
        public int Matches { get; set; }

        [JsonProperty("TeamName")]
        public string Name { get; set; }

        [JsonProperty("OpponentGoals")]
        public int OpponentGoals { get; set; }

        [JsonProperty("Points")]
        public int Points { get; set; }

        [JsonProperty("ShortName")]
        public string ShortName { get; set; }

        [JsonProperty("Won")]
        public int Won { get; set; }
    }
}
