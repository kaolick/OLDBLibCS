using Newtonsoft.Json;

namespace OLDBLibCS.Model
{
    public class Group
    {
        [JsonProperty("GroupID")]
        public int Id { get; set; }

        [JsonProperty("GroupName")]
        public string Name { get; set; }

        [JsonProperty("GroupOrderID")]
        public int OrderId { get; set; }
    }
}
