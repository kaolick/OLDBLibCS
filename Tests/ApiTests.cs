using System.Globalization;
using OLDBLibCS.API;
using OLDBLibCS.Model;

namespace OLDBLibCS.Tests
{
    public class ApiTests
    {
        readonly OLDBApi _api;
        readonly CancellationTokenSource _cts;

        public ApiTests()
        {
            _api = new OLDBApi();
            _cts = new CancellationTokenSource();
        }

        [Fact]
        public async Task GetAvailableGroups()
        {
            var groups = await _api.GetAvailableGroups("bl1", 2023, _cts.Token);

            Assert.IsType<List<Group>>(groups);
        }

        [Fact]
        public async Task GetAvailableLeagues()
        {
            var leagues = await _api.GetAvailableLeagues(_cts.Token);

            Assert.IsType<List<League>>(leagues);
        }
        
        [Fact]
        public async Task GetAvailableSports()
        {
            var sports = await _api.GetAvailableSports(_cts.Token);

            Assert.IsType<List<Sport>>(sports);
        }

        [Fact]
        public async Task GetAvailableTeams()
        {
            var teams = await _api.GetAvailableTeams("bl1", 2023, _cts.Token);

            Assert.IsType<List<Team>>(teams);
        }

        [Fact]
        public async Task GetBlTable()
        {
            var teams = await _api.GetBlTable("bl1", 2023, _cts.Token);

            Assert.IsType<List<BlTableTeam>>(teams);
        }

        [Fact]
        public async Task GetCurrentGroup()
        {
            var group = await _api.GetCurrentGroup("bl1", _cts.Token);

            Assert.IsType<Group>(group);
        }

        [Fact]
        public async Task GetGoalGetters()
        {
            var goalGetters = await _api.GetGoalGetters("bl1", 2023, _cts.Token);

            Assert.IsType<List<GoalGetter>>(goalGetters);
        }

        //[Fact]
        //public async Task GetGroupTable()
        //{
        //    var teams = await _api.GetGroupTable("bl1", 2023, _cts.Token);

        //    Assert.IsType<List<BlTableTeam>>(teams);
        //}

        [Fact]
        public async Task GetLastChangeDate()
        {
            var timestamp = await _api.GetLastChangeDate("bl1", 2023, 34, _cts.Token);

            var dateTime = DateTime.ParseExact(timestamp.Replace("\"", ""), "yyyy-MM-ddTHH:mm:ss.fff", CultureInfo.InvariantCulture);
            Assert.IsType<DateTime>(dateTime);
        }

        [Fact]
        public async Task GetMatchDataForCertainTeamForCompleteSeason()
        {
            var matches = await _api.GetMatchData("bl1", 2023, "Dortmund", _cts.Token);

            Assert.IsType<List<Match>>(matches);
        }

        [Fact]
        public async Task GetMatchDataForCompleteSeason()
        {
            var matches = await _api.GetMatchData("bl1", 2023, _cts.Token);

            Assert.IsType<List<Match>>(matches);
        }

        [Fact]
        public async Task GetMatchDataForCertainMatchday()
        {
            var matches = await _api.GetMatchData("bl1", 2023, 34, _cts.Token);

            Assert.IsType<List<Match>>(matches);
        }

        [Fact]
        public async Task GetMatchDataForCertainMatch()
        {
            var match = await _api.GetMatchData(51417, _cts.Token);

            Assert.IsType<Match>(match);
        }

        [Fact]
        public async Task GetMatchDataForTwoTeams()
        {
            var matches = await _api.GetMatchData(7, 9, _cts.Token);

            Assert.IsType<List<Match>>(matches);
        }

        [Fact]
        public async Task GetMatchesByTeam()
        {
            var matches = await _api.GetMatchesByTeam("Dortmund", 12, 4, _cts.Token);

            Assert.IsType<List<Match>>(matches);
        }

        [Fact]
        public async Task GetMatchesByTeamId()
        {
            var matches = await _api.GetMatchesByTeamId(7, 12, 4, _cts.Token);

            Assert.IsType<List<Match>>(matches);
        }

        [Fact]
        public async Task GetNextMatch()
        {
            var match = await _api.GetNextMatchByLeagueTeam(4741, 40, _cts.Token);

            Assert.IsType<Match>(match);
        }

        #region DFB-Pokal helper

        [Fact]
        public async Task WriteTeamIdsToFile()
        {
            var teams = await _api.GetAvailableTeams("dfb", 2023, _cts.Token);
            var teamIds = teams.Select(t => t.Id).OrderBy(i => i);
            var folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var fileName = "TeamIds.txt";
            var lines = new List<string>();

            foreach (var id in teamIds)
                lines.Add($"{id},");

            WriteLineToFile(Path.Combine(folder, fileName), lines);
        }

        [Fact]
        public async Task WriteTeamStoreEntriesToFile()
        {
            var teams = await _api.GetAvailableTeams("dfb", 2023, _cts.Token);
            var orderedTeams = teams.OrderBy(t => t.Id);
            var folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var fileName = "TeamStoreEntries.txt";
            var lines = new List<string>();

            foreach (var team in orderedTeams)
                lines.Add($"_teamDataDictionary.Add({team.Id}, new TeamData(\"{team.Name}\", \"{team.ShortName}\", \"{team.ShortName}\"));");

            WriteLineToFile(Path.Combine(folder, fileName), lines);
        }

        private void WriteLineToFile(string path, List<string> lines)
        {
            using (StreamWriter outputFile = new StreamWriter(path))
            {
                foreach (string line in lines)
                    outputFile.WriteLine(line);
            }
        }

        #endregion
    }
}
