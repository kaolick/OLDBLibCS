using Newtonsoft.Json;

namespace OLDBLibCS.Model
{
    public class Location
    {
        [JsonProperty("LocationCity")]
        public string City { get; set; }

        [JsonProperty("LocationID")]
        public int Id { get; set; }

        [JsonProperty("LocationStadium")]
        public string Stadium { get; set; }
    }
}
