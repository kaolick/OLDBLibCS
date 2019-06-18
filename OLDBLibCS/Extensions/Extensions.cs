using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace OLDBLibCS.Extensions
{
    public static class Extensions
    {
        public static string PrettifyJson(this string json)
        {
            return JToken.Parse(json).ToString(Formatting.Indented);
        }
    }
}
