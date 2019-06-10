using Newtonsoft.Json;

namespace OLDBLibCS.Model
{
    public class Team
    {
        [JsonProperty("TeamGroupName")]
        public string GroupName { get; set; }

        [JsonProperty("TeamIconUrl")]
        public string IconUrl { get; set; }

        [JsonProperty("TeamId")]
        public int Id { get; set; }

        [JsonProperty("TeamName")]
        public string Name { get; set; }

        [JsonProperty("ShortName")]
        public string ShortName { get; set; }
    }
}
