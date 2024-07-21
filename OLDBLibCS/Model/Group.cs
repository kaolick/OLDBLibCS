using System.Text.Json.Serialization;

namespace OLDBLibCS.Model
{
    public class Group
    {
        [JsonPropertyName("GroupID")]
        public int Id { get; set; }

        [JsonPropertyName("GroupName")]
        public string Name { get; set; }

        [JsonPropertyName("GroupOrderID")]
        public int OrderId { get; set; }
    }
}
