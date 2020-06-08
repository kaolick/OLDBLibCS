using System.Threading;
using System.Threading.Tasks;
using Refit;

namespace OLDBLibCS.API
{
    public interface IOLDBApi
    {
        [Get("/api/getcurrentgroup/{leagueShortcut}")]
        Task<string> GetCurrentGroup(string leagueShortcut, CancellationToken cancellationToken);

        [Get("/api/getmatchdata/{leagueShortcut}")]
        Task<string> GetMatchData(string leagueShortcut, CancellationToken cancellationToken);

        [Get("/api/getmatchdata/{leagueShortcut}/{leagueSeason}")]
        Task<string> GetMatchData(string leagueShortcut, int leagueSeason, CancellationToken cancellationToken);

        [Get("/api/getmatchdata/{leagueShortcut}/{leagueSeason}/{groupOrderId}")]
        Task<string> GetMatchData(string leagueShortcut, int leagueSeason, int groupOrderId, CancellationToken cancellationToken);

        [Get("/api/getmatchdata/{matchId}")]
        Task<string> GetMatchData(int matchId, CancellationToken cancellationToken);
    }
}
