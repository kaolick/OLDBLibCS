using System.Text.Json.Serialization;

namespace OLDBLibCS.Model
{
	public class GlobalResultInfo
	{
		[JsonPropertyName("id")]
		public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
	}
}
