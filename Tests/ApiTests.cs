using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OLDBLibCS.API;
using OLDBLibCS.Extensions;
using OLDBLibCS.Model;
using OLDBLibCS.Parser;

namespace OLDBLibCS.Tests
{
    [TestFixture]
    public class ApiTests
    {
        OLDBApi _api;
        OLDBParser _parser;
        CancellationTokenSource _cts;

        [SetUp]
        public void SetUp()
        {
            _api = new OLDBApi();
            _parser = new OLDBParser();
            _cts = new CancellationTokenSource();
        }

        [Test]
        public async Task GetCurrentGroup()
        {
            var json = await _api.GetCurrentGroup("bl1", _cts.Token);

            var group = _parser.ParseGroup(json);
            Assert.IsInstanceOf<Group>(group);
        }

        [Test]
        public async Task GetMatchDataForCurrentMatchday()
        {
            var json = await _api.GetMatchData("bl1", _cts.Token);

            AssertIsListOfMatches(json);
        }

        [Test]
        public async Task GetMatchDataForCompleteSeason()
        {
            var json = await _api.GetMatchData("bl1", 2018, _cts.Token);

            AssertIsListOfMatches(json);
        }

        [Test]
        public async Task GetMatchDataForCertainMatchday()
        {
            var json = await _api.GetMatchData("bl1", 2018, 34, _cts.Token);

            AssertIsListOfMatches(json);
        }

        [Test]
        public async Task GetMatchDataForCertainMatch()
        {
            var json = await _api.GetMatchData(51417, _cts.Token);

            var match = _parser.ParseMatch(json);
            Assert.IsInstanceOf<Match>(match);
        }

        void LogJson(string json) => Console.WriteLine(json.PrettifyJson());

        void AssertIsListOfMatches(string json)
        {
            var matches = _parser.ParseMatches(json);
            Assert.IsInstanceOf<List<Match>>(matches);
        }
    }
}
