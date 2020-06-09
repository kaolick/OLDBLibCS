using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OLDBLibCS.API;
using OLDBLibCS.Extensions;
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
        public async Task GetCurrentGroup()
        {
            var group = await _api.GetCurrentGroup("bl1", _cts.Token);

            Assert.IsInstanceOf<Group>(group);
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

        void LogJson(string json) => Console.WriteLine(json.PrettifyJson());
    }
}
