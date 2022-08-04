using Badminton.Classes;
using System.ComponentModel;
using Xunit;

namespace Badminton.Tests
{
    public class EloCalculatorTests
    {
        [Fact]
        public void When_AllPlayersHaveSameElo_EloChangesBy10()
        {
            var eloCalculator = new EloCalculator();

            var team1Player1 = new Player("team1Player1", Enums.Gender.Male) { Elo = 1600 };
            var team1Player2 = new Player("team1Player2", Enums.Gender.Male) { Elo = 1600 };
            var team2Player1 = new Player("team2Player1", Enums.Gender.Male) { Elo = 1600 };
            var team2Player2 = new Player("team2Player2", Enums.Gender.Male) { Elo = 1600 };

            var match = new Match
            {
                Team1Players = new BindingList<Player> { team1Player1, team1Player2 },
                Team2Players = new BindingList<Player> { team2Player1, team2Player2 },
                Team1Score = 21,
                Team2Score = 19,
            };

            EloCalculator.UpdateElo(match);

            Assert.Equal(1610, team1Player1.Elo);
            Assert.Equal(1610, team1Player2.Elo);
            Assert.Equal(1590, team2Player1.Elo);
            Assert.Equal(1590, team2Player2.Elo);
        }
    }
}