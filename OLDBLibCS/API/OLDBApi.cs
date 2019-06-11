using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Refit;

namespace OLDBLibCS.API
{
    public class OLDBApi : IOLDBApi
    {
        const string _baseUrl = "https://www.openligadb.de/";
        readonly IOLDBApi _oldbApi;

        public OLDBApi(double timeoutSeconds = 15)
        {
            _oldbApi = RestService.For<IOLDBApi>(new HttpClient
            {
                BaseAddress = new Uri(_baseUrl),
                Timeout = TimeSpan.FromSeconds(timeoutSeconds)
            });
        }

        public async Task<string> GetCurrentGroup(string leagueShortcut, CancellationToken cancellationToken)
        {
            return await _oldbApi.GetCurrentGroup(leagueShortcut, cancellationToken);
        }

        public async Task<string> GetMatchData(string leagueShortcut, int leagueSeason, CancellationToken cancellationToken)
        {
            return await _oldbApi.GetMatchData(leagueShortcut, leagueSeason, cancellationToken);
        }

        public async Task<string> GetMatchData(string leagueShortcut, int leagueSeason, int groupOrderId, CancellationToken cancellationToken)
        {
            return await _oldbApi.GetMatchData(leagueShortcut, leagueSeason, groupOrderId, cancellationToken);
        }
    }
}
