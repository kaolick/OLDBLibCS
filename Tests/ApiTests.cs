using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OLDBLibCS.API;
using OLDBLibCS.Model;

namespace OLDBLibCS.Tests
{
    [TestFixture]
    public class ApiTests
    {
        OLDBApi _api;
        CancellationTokenSource _cts;

        [SetUp]
        public void SetUp()
        {
            _api = new OLDBApi();
            _cts = new CancellationTokenSource();
        }

        [Test]
        public async Task GetAvailableGroups()
        {
            var groups = await _api.GetAvailableGroups("bl1", 2018, _cts.Token);

            Assert.IsInstanceOf<List<Group>>(groups);
        }

        [Test]
        public async Task GetAvailableTeams()
        {
            var teams = await _api.GetAvailableTeams("bl1", 2018, _cts.Token);

            Assert.IsInstanceOf<List<Team>>(teams);
        }

        [Test]
        public async Task GetBLTable()
        {
            var teams = await _api.GetBLTable("bl1", 2018, _cts.Token);

            Assert.IsInstanceOf<List<BLTableTeam>>(teams);
        }

        [Test]
        public async Task GetCurrentGroup()
        {
            var group = await _api.GetCurrentGroup("bl1", _cts.Token);

            Assert.IsInstanceOf<Group>(group);
        }

        [Test]
        public async Task GetGoalGetters()
        {
            var goalGetters = await _api.GetGoalGetters("bl1", 2018, _cts.Token);

            Assert.IsInstanceOf<List<GoalGetter>>(goalGetters);
        }

        [Test]
        public async Task GetLastChangeDate()
        {
            var timestamp = await _api.GetLastChangeDate("bl1", 2018, 34, _cts.Token);

            var dateTime = DateTime.ParseExact(timestamp.Replace("\"", ""), "yyyy-MM-ddTHH:mm:ss.fff", CultureInfo.InvariantCulture);
            Assert.IsInstanceOf<DateTime>(dateTime);
        }

        [Test]
        public async Task GetMatchDataForCurrentMatchday()
        {
            var matches = await _api.GetMatchData("bl1", _cts.Token);

            Assert.IsInstanceOf<List<Match>>(matches);
        }

        [Test]
        public async Task GetMatchDataForCompleteSeason()
        {
            var matches = await _api.GetMatchData("bl1", 2018, _cts.Token);

            Assert.IsInstanceOf<List<Match>>(matches);
        }

        [Test]
        public async Task GetMatchDataForCertainMatchday()
        {
            var matches = await _api.GetMatchData("bl1", 2018, 34, _cts.Token);

            Assert.IsInstanceOf<List<Match>>(matches);
        }

        [Test]
        public async Task GetMatchDataForCertainMatch()
        {
            var match = await _api.GetMatchData(51417, _cts.Token);

            Assert.IsInstanceOf<Match>(match);
        }

        [Test]
        public async Task GetMatchDataForTwoTeams()
        {
            var matches = await _api.GetMatchData(7, 9, _cts.Token);

            Assert.IsInstanceOf<List<Match>>(matches);
        }

        [Test]
        public async Task GetNextMatch()
        {
            var match = await _api.GetNextMatchByLeagueTeam(4608, 40, _cts.Token);

            Assert.IsInstanceOf<Match>(match);
        }
    }
}
