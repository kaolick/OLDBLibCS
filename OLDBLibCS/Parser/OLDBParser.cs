using System.Collections.Generic;
using Newtonsoft.Json;
using OLDBLibCS.Model;

namespace OLDBLibCS.Parser
{
    public class OLDBParser
    {
        public Group ParseGroup(string json,
            NullValueHandling nullValueHandling = NullValueHandling.Ignore,
            MissingMemberHandling missingMemberHandling = MissingMemberHandling.Ignore)
        {
            var settings = CreateSettings(nullValueHandling, missingMemberHandling);
            return JsonConvert.DeserializeObject<Group>(json, settings);
        }

        public List<Match> ParseMatches(string json,
            NullValueHandling nullValueHandling = NullValueHandling.Ignore,
            MissingMemberHandling missingMemberHandling = MissingMemberHandling.Ignore)
        {
            var settings = CreateSettings(nullValueHandling, missingMemberHandling);
            return JsonConvert.DeserializeObject<List<Match>>(json, settings);
        }

        JsonSerializerSettings CreateSettings(
            NullValueHandling nullValueHandling,
            MissingMemberHandling missingMemberHandling)
        {
            return new JsonSerializerSettings
            {
                NullValueHandling = nullValueHandling,
                MissingMemberHandling = missingMemberHandling
            };
        }
    }
}
