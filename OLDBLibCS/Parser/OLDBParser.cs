using System.Collections.Generic;
using Newtonsoft.Json;
using OLDBLibCS.Model;

namespace OLDBLibCS.Parser
{
    public class OLDBParser
    {
        readonly JsonSerializerSettings _settings;

        public OLDBParser()
        {
            _settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };
        }

        public Group ParseGroup(string json) => JsonConvert.DeserializeObject<Group>(json, _settings);

        public Match ParseMatch(string json) => JsonConvert.DeserializeObject<Match>(json, _settings);

        public List<Match> ParseMatches(string json) => JsonConvert.DeserializeObject<List<Match>>(json, _settings);
    }
}
