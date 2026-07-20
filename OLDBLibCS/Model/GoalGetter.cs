#nullable enable
using System.Text.Json.Serialization;

namespace OLDBLibCS.Model
{
    public class GoalGetter
    {
        [JsonPropertyName("GoalGetterId")]
        public int Id { get; set; }

        [JsonPropertyName("GoalGetterName")]
        public string? Name { get; set; }

        [JsonPropertyName("GoalCount")]
        public int GoalCount { get; set; }
    }
}
