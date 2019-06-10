using System.Collections.Generic;
using Newtonsoft.Json;

namespace OLDBLibCS.Model
{
    public class Match
    {
        [JsonProperty("MatchDateTime")]
        public string DateTime { get; private set; }

        [JsonProperty("MatchDateTimeUTC")]
        public string DateTimeUTC { get; private set; }

        [JsonProperty("Goals")]
        public List<Goal> Goals { get; set; }

        [JsonProperty("Group")]
        public Group Group { get; set; }

        [JsonProperty("MatchID")]
        public int Id { get; private set; }

        [JsonProperty("MatchIsFinished")]
        public bool IsFinished { get; private set; }

        [JsonProperty("LastUpdateDateTime")]
        public string LastUpdateDateTime { get; set; }

        [JsonProperty("LeagueId")]
        public int LeagueId { get; private set; }

        [JsonProperty("LeagueName")]
        public string LeagueName { get; private set; }

        [JsonProperty("Location")]
        public Location Location { get; private set; }

        [JsonProperty("NumberOfViewers")]
        public int NumberOfViewers { get; private set; }

        [JsonProperty("MatchResults")]
        public List<MatchResult> Results { get; private set; }

        [JsonProperty("Team1")]
        public Team Team1 { get; private set; }

        [JsonProperty("Team2")]
        public Team Team2 { get; private set; }

        [JsonProperty("TimeZoneID")]
        public string TimeZoneID { get; private set; }
    }
}
