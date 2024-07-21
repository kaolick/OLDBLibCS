using System.Text.Json.Serialization;

namespace OLDBLibCS.Model
{
	public class Sport
	{
		[JsonPropertyName("sportId")]
		public int Id { get; set; }

        [JsonPropertyName("sportName")]
        public string Name { get; set; }
    }
}
