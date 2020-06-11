using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using OLDBLibCS.Model;
using Refit;

namespace OLDBLibCS.API
{
    public interface IOLDBApi
    {
        [Get("/api/getavailablegroups/{leagueShortcut}/{leagueSeason}")]
        Task<List<Group>> GetAvailableGroups(string leagueShortcut, int leagueSeason, CancellationToken cancellationToken);

        [Get("/api/getavailableteams/{leagueShortcut}/{leagueSeason}")]
        Task<List<Team>> GetAvailableTeams(string leagueShortcut, int leagueSeason, CancellationToken cancellationToken);

        [Get("/api/getcurrentgroup/{leagueShortcut}")]
        Task<Group> GetCurrentGroup(string leagueShortcut, CancellationToken cancellationToken);

        [Get("/api/getgoalgetters/{leagueShortcut}/{leagueSeason}")]
        Task<List<GoalGetter>> GetGoalGetters(string leagueShortcut, int leagueSeason, CancellationToken cancellationToken);

        [Get("/api/getlastchangedate/{leagueShortcut}/{leagueSeason}/{groupOrderId}")]
        Task<string> GetLastChangeDate(string leagueShortcut, int leagueSeason, int groupOrderId, CancellationToken cancellationToken);

        [Get("/api/getmatchdata/{leagueShortcut}")]
        Task<List<Match>> GetMatchData(string leagueShortcut, CancellationToken cancellationToken);

        [Get("/api/getmatchdata/{leagueShortcut}/{leagueSeason}")]
        Task<List<Match>> GetMatchData(string leagueShortcut, int leagueSeason, CancellationToken cancellationToken);

        [Get("/api/getmatchdata/{leagueShortcut}/{leagueSeason}/{groupOrderId}")]
        Task<List<Match>> GetMatchData(string leagueShortcut, int leagueSeason, int groupOrderId, CancellationToken cancellationToken);

        [Get("/api/getmatchdata/{matchId}")]
        Task<Match> GetMatchData(int matchId, CancellationToken cancellationToken);

        [Get("/api/getmatchdata/{team1Id}/{team2Id}")]
        Task<List<Match>> GetMatchData(int team1Id, int team2Id, CancellationToken cancellationToken);

        [Get("/api/getnextmatchbyleagueteam/{leagueId}/{teamId}")]
        Task<Match> GetNextMatchByLeagueTeam(int leagueId, int teamId, CancellationToken cancellationToken);
    }
}
