using System.Text.Json.Serialization;

namespace OLDBLibCS.Model
{
	public class League
	{
		[JsonPropertyName("leagueId")]
		public int Id { get; set; }

        [JsonPropertyName("leagueName")]
        public string Name { get; set; }

        [JsonPropertyName("leagueSeason")]
        public string Season { get; set; }

        [JsonPropertyName("leagueShortcut")]
        public string Shortcut { get; set; }

        [JsonPropertyName("sport")]
        public Sport Sport { get; set; }
    }
}
