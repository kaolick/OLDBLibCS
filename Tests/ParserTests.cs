using NUnit.Framework;
using OLDBLibCS.Parser;

namespace OLDBLibCS.Tests
{
    [TestFixture]
    public class ParserTests
    {
        OLDBParser _parser;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _parser = new OLDBParser();
        }

        [Test]
        public void ParseGroup()
        {
            var json = FileReader.ReadTextFromFile("CurrentGroup.json");
            var group = _parser.ParseGroup(json);

            Assert.That(group.Id, Is.EqualTo(12345));
            Assert.That(group.Name, Is.EqualTo("Some group name"));
            Assert.That(group.OrderId, Is.EqualTo(1));
        }

        [Test]
        public void ParseMatches()
        {
            var json = FileReader.ReadTextFromFile("Matches.json");
            var matches = _parser.ParseMatches(json);
            Assert.That(matches.Count, Is.EqualTo(1));

            var match = matches[0];
            Assert.That(match.DateTime, Is.EqualTo("2019-05-29T20:30:00"));
            Assert.That(match.DateTimeUTC, Is.EqualTo("2019-05-29T19:30:00Z"));
            Assert.That(match.Id, Is.EqualTo(12345));
            Assert.That(match.IsFinished, Is.True);
            Assert.That(match.LastUpdateDateTime, Is.EqualTo("2019-05-29T22:30:00.00"));
            Assert.That(match.LeagueId, Is.EqualTo(54321));
            Assert.That(match.LeagueName, Is.EqualTo("Some league name"));
            Assert.That(match.NumberOfViewers, Is.EqualTo(42000));
            Assert.That(match.TimeZoneID, Is.EqualTo("W. Europe Standard Time"));

            var goals = match.Goals;
            Assert.That(goals.Count, Is.EqualTo(1));

            var lastGoal = goals[0];
            Assert.That(lastGoal.Comment, Is.EqualTo("What a goal"));
            Assert.That(lastGoal.Id, Is.EqualTo(1000));
            Assert.That(lastGoal.IsOwnGoal, Is.False);
            Assert.That(lastGoal.IsPenalty, Is.True);
            Assert.That(lastGoal.IsOvertime, Is.True);
            Assert.That(lastGoal.GoalGetterId, Is.EqualTo(13579));
            Assert.That(lastGoal.GoalGetterName, Is.EqualTo("Messi"));
            Assert.That(lastGoal.MatchMinute, Is.EqualTo(95));
            Assert.That(lastGoal.ScoreTeam1, Is.EqualTo(1));
            Assert.That(lastGoal.ScoreTeam2, Is.EqualTo(0));

            var group = match.Group;
            Assert.That(group.Id, Is.EqualTo(67890));
            Assert.That(group.Name, Is.EqualTo("Some group name"));
            Assert.That(group.OrderId, Is.EqualTo(1));

            var location = match.Location;
            Assert.That(location.City, Is.EqualTo("Some city"));
            Assert.That(location.Id, Is.EqualTo(98765));
            Assert.That(location.Stadium, Is.EqualTo("Some stadium"));

            var results = match.Results;
            Assert.That(results.Count, Is.EqualTo(2));

            var firstResult = results[0];
            Assert.That(firstResult.Description, Is.EqualTo("Ergebnis zur Halbzeit"));
            Assert.That(firstResult.Id, Is.EqualTo(100));
            Assert.That(firstResult.Name, Is.EqualTo("Halbzeitergebnis"));
            Assert.That(firstResult.OrderId, Is.EqualTo(1));
            Assert.That(firstResult.PointsTeam1, Is.EqualTo(0));
            Assert.That(firstResult.PointsTeam2, Is.EqualTo(0));
            Assert.That(firstResult.TypeId, Is.EqualTo(1));

            var lastResult = results[1];
            Assert.That(lastResult.Description, Is.EqualTo("Ergebnis nach Spielende"));
            Assert.That(lastResult.Id, Is.EqualTo(101));
            Assert.That(lastResult.Name, Is.EqualTo("Endergebnis"));
            Assert.That(lastResult.OrderId, Is.EqualTo(2));
            Assert.That(lastResult.PointsTeam1, Is.EqualTo(1));
            Assert.That(lastResult.PointsTeam2, Is.EqualTo(0));
            Assert.That(lastResult.TypeId, Is.EqualTo(2));

            var team1 = match.Team1;
            Assert.That(team1.Id, Is.EqualTo(1));
            Assert.That(team1.Name, Is.EqualTo("Team 1"));
            Assert.That(team1.ShortName, Is.EqualTo("T 1"));
            Assert.That(team1.IconUrl, Is.EqualTo("https://team1_logo.png"));

            var team2 = match.Team2;
            Assert.That(team2.Id, Is.EqualTo(2));
            Assert.That(team2.Name, Is.EqualTo("Team 2"));
            Assert.That(team2.ShortName, Is.EqualTo("T 2"));
            Assert.That(team2.IconUrl, Is.EqualTo("https://team2_logo.png"));
        }
    }
}
