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
            var json = await _api.GetCurrentGroup("wm2018ru", _cts.Token);
            Console.WriteLine(json.PrettifyJson());

            var group = _parser.ParseGroup(json);

            Assert.IsInstanceOf<Group>(group);
        }

        [Test]
        public async Task GetMatchDataForCertainMatchday()
        {
            var json = await _api.GetMatchData("bl1", 2018, 34, _cts.Token);
            Console.WriteLine(json.PrettifyJson());

            var matches = _parser.ParseMatches(json);

            Assert.IsInstanceOf<List<Match>>(matches);
        }
    }
}
