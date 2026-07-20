#nullable enable
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OLDBLibCS.Model
{
    public class Match
    {
        [JsonPropertyName("matchID")]
        public int Id { get; set; }
        
        [JsonPropertyName("matchDateTime")]
        public string? DateTime { get; set; }
        
        [JsonPropertyName("timeZoneID")]
        public string? TimeZoneID { get; set; }

        [JsonPropertyName("leagueId")]
        public int LeagueId { get; set; }
        
        [JsonPropertyName("leagueName")]
        public string? LeagueName { get; set; }
        
        [JsonPropertyName("leagueSeason")]
        public int LeagueSeason { get; set; }
        
        [JsonPropertyName("leagueShortcut")]
        public string? LeagueShortcut { get; set; }
        
        [JsonPropertyName("matchDateTimeUTC")]
        public string? DateTimeUTC { get; set; }
        
        [JsonPropertyName("group")]
        public Group? Group { get; set; }
        
        [JsonPropertyName("team1")]
        public Team? Team1 { get; set; }

        [JsonPropertyName("team2")]
        public Team? Team2 { get; set; }
        
        [JsonPropertyName("lastUpdateDateTime")]
        public string? LastUpdateDateTime { get; set; }
        
        [JsonPropertyName("matchIsFinished")]
        public bool IsFinished { get; set; }

        [JsonPropertyName("matchResults")]
        public List<MatchResult>? Results { get; set; }
        
        [JsonPropertyName("goals")]
        public List<Goal>? Goals { get; set; }

        [JsonPropertyName("location")]
        public Location? Location { get; set; }

        [JsonPropertyName("numberOfViewers")]
        public int? NumberOfViewers { get; set; }
    }
}
