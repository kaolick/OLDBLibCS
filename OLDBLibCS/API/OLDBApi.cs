﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
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

        public async Task<List<Team>> GetAvailableTeams(string leagueShortcut, int leagueSeason, CancellationToken cancellationToken)
        {
            return await _oldbApi.GetAvailableTeams(leagueShortcut, leagueSeason, cancellationToken);
        }

        public async Task<List<BLTableTeam>> GetBLTable(string leagueShortcut, int leagueSeason, CancellationToken cancellationToken)
        {
            return await _oldbApi.GetBLTable(leagueShortcut, leagueSeason, cancellationToken);
        }

        public async Task<Group> GetCurrentGroup(string leagueShortcut, CancellationToken cancellationToken)
        {
            return await _oldbApi.GetCurrentGroup(leagueShortcut, cancellationToken);
        }

        public async Task<List<GoalGetter>> GetGoalGetters(string leagueShortcut, int leagueSeason, CancellationToken cancellationToken)
        {
            return await _oldbApi.GetGoalGetters(leagueShortcut, leagueSeason, cancellationToken);
        }

        public async Task<string> GetLastChangeDate(string leagueShortcut, int leagueSeason, int groupOrderId, CancellationToken cancellationToken)
        {
            return await _oldbApi.GetLastChangeDate(leagueShortcut, leagueSeason, groupOrderId, cancellationToken);
        }

        public async Task<List<Match>> GetMatchData(string leagueShortcut, CancellationToken cancellationToken)
        {
            return await _oldbApi.GetMatchData(leagueShortcut, cancellationToken);
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

        public async Task<Match> GetNextMatchByLeagueTeam(int leagueId, int teamId, CancellationToken cancellationToken)
        {
            return await _oldbApi.GetNextMatchByLeagueTeam(leagueId, teamId, cancellationToken);
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
            var jsonSettings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };

            return new RefitSettings
            {
                ContentSerializer = new NewtonsoftJsonContentSerializer(jsonSettings)
            };
        }
    }
}
