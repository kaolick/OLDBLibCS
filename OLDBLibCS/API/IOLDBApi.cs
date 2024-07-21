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

        [Get("/api/getavailableleagues")]
        Task<List<League>> GetAvailableLeagues(CancellationToken cancellationToken);

        [Get("/api/getavailablesports")]
        Task<List<Sport>> GetAvailableSports(CancellationToken cancellationToken);

        [Get("/api/getavailableteams/{leagueShortcut}/{leagueSeason}")]
        Task<List<Team>> GetAvailableTeams(string leagueShortcut, int leagueSeason, CancellationToken cancellationToken);

        [Get("/api/getbltable/{leagueShortcut}/{leagueSeason}")]
        Task<List<BlTableTeam>> GetBlTable(string leagueShortcut, int leagueSeason, CancellationToken cancellationToken);

        [Get("/api/getcurrentgroup/{leagueShortcut}")]
        Task<Group> GetCurrentGroup(string leagueShortcut, CancellationToken cancellationToken);

        [Get("/api/getgoalgetters/{leagueShortcut}/{leagueSeason}")]
        Task<List<GoalGetter>> GetGoalGetters(string leagueShortcut, int leagueSeason, CancellationToken cancellationToken);

        //[Get("/api/getgrouptable/{leagueShortcut}/{leagueSeason}")]
        //Task<List<BlTableTeam>> GetGroupTable(string leagueShortcut, int leagueSeason, CancellationToken cancellationToken);

        [Get("/api/getlastchangedate/{leagueShortcut}/{leagueSeason}/{groupOrderId}")]
        Task<string> GetLastChangeDate(string leagueShortcut, int leagueSeason, int groupOrderId, CancellationToken cancellationToken);

        [Get("/api/getlastmatchbyleagueteam/{leagueId}/{teamId}")]
        Task<Match> GetLastMatchByLeagueTeam(int leagueId, int teamId, CancellationToken cancellationToken);

        [Get("/api/getlastmatchbyleagueteam/{leagueShortcut}")]
        Task<Match> GetLastMatchByLeagueShortcut(string leagueShortcut, CancellationToken cancellationToken);

        [Get("/api/getmatchdata/{leagueShortcut}/{leagueSeason}/{teamFilterstring}")]
        Task<List<Match>> GetMatchData(string leagueShortcut, int leagueSeason, string teamFilterstring, CancellationToken cancellationToken);

        [Get("/api/getmatchdata/{leagueShortcut}/{leagueSeason}")]
        Task<List<Match>> GetMatchData(string leagueShortcut, int leagueSeason, CancellationToken cancellationToken);

        [Get("/api/getmatchdata/{leagueShortcut}/{leagueSeason}/{groupOrderId}")]
        Task<List<Match>> GetMatchData(string leagueShortcut, int leagueSeason, int groupOrderId, CancellationToken cancellationToken);

        [Get("/api/getmatchdata/{matchId}")]
        Task<Match> GetMatchData(int matchId, CancellationToken cancellationToken);

        [Get("/api/getmatchdata/{team1Id}/{team2Id}")]
        Task<List<Match>> GetMatchData(int team1Id, int team2Id, CancellationToken cancellationToken);

        [Get("/api/getmatchesbyteam/{teamFilterstring}/{weekCountPast}/{weekCountFuture}")]
        Task<List<Match>> GetMatchesByTeam(string teamFilterstring, int weekCountPast, int weekCountFuture, CancellationToken cancellationToken);

        [Get("/api/getmatchesbyteamid/{teamId}/{weekCountPast}/{weekCountFuture}")]
        Task<List<Match>> GetMatchesByTeamId(int teamId, int weekCountPast, int weekCountFuture, CancellationToken cancellationToken);

        [Get("/api/getnextmatchbyleagueteam/{leagueId}/{teamId}")]
        Task<Match> GetNextMatchByLeagueTeam(int leagueId, int teamId, CancellationToken cancellationToken);

        [Get("/api/getnextmatchbyleagueteam/{leagueShortcut}")]
        Task<Match> GetNextMatchByLeagueShortcut(string leagueShortcut, CancellationToken cancellationToken);

        [Get("/api/getresultinfos/{leagueId}")]
        Task<List<ResultInfo>> GetResultInfos(int leagueId, CancellationToken cancellationToken);
    }
}
