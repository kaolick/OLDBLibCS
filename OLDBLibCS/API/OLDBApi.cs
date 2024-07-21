using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using OLDBLibCS.Model;
using Refit;

namespace OLDBLibCS.API
{
    public class OLDBApi : IOLDBApi
    {
        const string _baseUrl = "https://www.openligadb.de/";
        readonly IOLDBApi _oldbApi;

        public OLDBApi(double timeoutSeconds = 15)
        {
            var client = CreateHttpClient(timeoutSeconds);
            var refitSettings = CreateRefitSettings();
            _oldbApi = RestService.For<IOLDBApi>(client, refitSettings);
        }

        public async Task<List<Group>> GetAvailableGroups(string leagueShortcut, int leagueSeason, CancellationToken cancellationToken)
        {
            return await _oldbApi.GetAvailableGroups(leagueShortcut, leagueSeason, cancellationToken);
        }

        public async Task<List<League>> GetAvailableLeagues(CancellationToken cancellationToken)
        {
            return await _oldbApi.GetAvailableLeagues(cancellationToken);
        }

        public async Task<List<Sport>> GetAvailableSports(CancellationToken cancellationToken)
        {
            return await _oldbApi.GetAvailableSports(cancellationToken);
        }

        public async Task<List<Team>> GetAvailableTeams(string leagueShortcut, int leagueSeason, CancellationToken cancellationToken)
        {
            return await _oldbApi.GetAvailableTeams(leagueShortcut, leagueSeason, cancellationToken);
        }

        public async Task<List<BlTableTeam>> GetBlTable(string leagueShortcut, int leagueSeason, CancellationToken cancellationToken)
        {
            return await _oldbApi.GetBlTable(leagueShortcut, leagueSeason, cancellationToken);
        }

        public async Task<Group> GetCurrentGroup(string leagueShortcut, CancellationToken cancellationToken)
        {
            return await _oldbApi.GetCurrentGroup(leagueShortcut, cancellationToken);
        }

        public async Task<List<GoalGetter>> GetGoalGetters(string leagueShortcut, int leagueSeason, CancellationToken cancellationToken)
        {
            return await _oldbApi.GetGoalGetters(leagueShortcut, leagueSeason, cancellationToken);
        }

        //public async Task<List<BlTableTeam>> GetGroupTable(string leagueShortcut, int leagueSeason, CancellationToken cancellationToken)
        //{
        //    return await _oldbApi.GetGroupTable(leagueShortcut, leagueSeason, cancellationToken);
        //}

        public async Task<string> GetLastChangeDate(string leagueShortcut, int leagueSeason, int groupOrderId, CancellationToken cancellationToken)
        {
            return await _oldbApi.GetLastChangeDate(leagueShortcut, leagueSeason, groupOrderId, cancellationToken);
        }

        public async Task<Match> GetLastMatchByLeagueTeam(int leagueId, int teamId, CancellationToken cancellationToken)
        {
            return await _oldbApi.GetLastMatchByLeagueTeam(leagueId, teamId, cancellationToken);
        }

        public async Task<Match> GetLastMatchByLeagueShortcut(string leagueShortcut, CancellationToken cancellationToken)
        {
            return await _oldbApi.GetLastMatchByLeagueShortcut(leagueShortcut, cancellationToken);
        }

        public async Task<List<Match>> GetMatchData(string leagueShortcut, int leagueSeason, string teamFilterString, CancellationToken cancellationToken)
        {
            return await _oldbApi.GetMatchData(leagueShortcut, leagueSeason, teamFilterString,cancellationToken);
        }

        public async Task<List<Match>> GetMatchData(string leagueShortcut, int leagueSeason, CancellationToken cancellationToken)
        {
            return await _oldbApi.GetMatchData(leagueShortcut, leagueSeason, cancellationToken);
        }

        public async Task<List<Match>> GetMatchData(string leagueShortcut, int leagueSeason, int groupOrderId, CancellationToken cancellationToken)
        {
            return await _oldbApi.GetMatchData(leagueShortcut, leagueSeason, groupOrderId, cancellationToken);
        }

        public async Task<Match> GetMatchData(int matchId, CancellationToken cancellationToken)
        {
            return await _oldbApi.GetMatchData(matchId, cancellationToken);
        }

        public async Task<List<Match>> GetMatchData(int team1Id, int team2Id, CancellationToken cancellationToken)
        {
            return await _oldbApi.GetMatchData(team1Id, team2Id, cancellationToken);
        }

        public async Task<List<Match>> GetMatchesByTeam(string teamFilterstring, int weekCountPast, int weekCountFuture, CancellationToken cancellationToken)
        {
            return await _oldbApi.GetMatchesByTeam(teamFilterstring, weekCountPast, weekCountFuture, cancellationToken);
        }

        public async Task<List<Match>> GetMatchesByTeamId(int teamId, int weekCountPast, int weekCountFuture, CancellationToken cancellationToken)
        {
            return await _oldbApi.GetMatchesByTeamId(teamId, weekCountPast, weekCountFuture, cancellationToken);
        }

        public async Task<Match> GetNextMatchByLeagueTeam(int leagueId, int teamId, CancellationToken cancellationToken)
        {
            return await _oldbApi.GetNextMatchByLeagueTeam(leagueId, teamId, cancellationToken);
        }

        public async Task<Match> GetNextMatchByLeagueShortcut(string leagueShortcut, CancellationToken cancellationToken)
        {
            return await _oldbApi.GetNextMatchByLeagueShortcut(leagueShortcut, cancellationToken);
        }

        public async Task<List<ResultInfo>> GetResultInfos(int leagueId, CancellationToken cancellationToken)
        {
            return await _oldbApi.GetResultInfos(leagueId, cancellationToken);
        }

        HttpClient CreateHttpClient(double timeoutSeconds)
        {
            return new HttpClient
            {
                BaseAddress = new Uri(_baseUrl),
                Timeout = TimeSpan.FromSeconds(timeoutSeconds)
            };
        }

        RefitSettings CreateRefitSettings()
        {
            var jsonSettings = new JsonSerializerOptions
            {
                AllowTrailingCommas = true,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                PropertyNameCaseInsensitive = true,
                ReadCommentHandling = JsonCommentHandling.Skip,
            };

            return new RefitSettings
            {
                ContentSerializer = new SystemTextJsonContentSerializer(jsonSettings)
            };
        }
    }
}
