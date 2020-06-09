using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using OLDBLibCS.Model;
using Refit;

namespace OLDBLibCS.API
{
    public interface IOLDBApi
    {
        [Get("/api/getcurrentgroup/{leagueShortcut}")]
        Task<Group> GetCurrentGroup(string leagueShortcut, CancellationToken cancellationToken);

        [Get("/api/getmatchdata/{leagueShortcut}")]
        Task<List<Match>> GetMatchData(string leagueShortcut, CancellationToken cancellationToken);

        [Get("/api/getmatchdata/{leagueShortcut}/{leagueSeason}")]
        Task<List<Match>> GetMatchData(string leagueShortcut, int leagueSeason, CancellationToken cancellationToken);

        [Get("/api/getmatchdata/{leagueShortcut}/{leagueSeason}/{groupOrderId}")]
        Task<List<Match>> GetMatchData(string leagueShortcut, int leagueSeason, int groupOrderId, CancellationToken cancellationToken);

        [Get("/api/getmatchdata/{matchId}")]
        Task<Match> GetMatchData(int matchId, CancellationToken cancellationToken);
    }
}
