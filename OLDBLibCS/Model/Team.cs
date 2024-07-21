using System.Text.Json.Serialization;

namespace OLDBLibCS.Model
{
    public class Team
    {
        [JsonPropertyName("teamGroupName")]
        public string GroupName { get; set; }

        [JsonPropertyName("teamIconUrl")]
        public string IconUrl { get; set; }

        [JsonPropertyName("teamId")]
        public int Id { get; set; }

        [JsonPropertyName("teamName")]
        public string Name { get; set; }

        [JsonPropertyName("shortName")]
        public string ShortName { get; set; }
    }
}
