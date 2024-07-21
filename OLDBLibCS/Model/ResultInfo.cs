using System.Text.Json.Serialization;

namespace OLDBLibCS.Model
{
	public class ResultInfo
	{
        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("globalResultInfo")]
        public GlobalResultInfo GlobalResultInfo { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("orderId")]
        public int? OrderId { get; set; }
    }
}
