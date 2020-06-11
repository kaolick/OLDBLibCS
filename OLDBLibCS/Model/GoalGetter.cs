using Newtonsoft.Json;

namespace OLDBLibCS.Model
{
    public class GoalGetter
    {
        [JsonProperty("GoalCount")]
        public int GoalCount { get; set; }

        [JsonProperty("GoalGetterId")]
        public int GoalGetterId { get; set; }

        [JsonProperty("GoalGetterName")]
        public string GoalGetterName { get; set; }
    }
}
