using Badminton.Enums;

namespace Badminton.Classes
{
    public class MatchPicker
    {
        public void PickMatch(string? GameType, Session session)
        {
            foreach (var player in session.MatchPreview.Players)
            {
                session.WaitingPlayers.Add(player);
            }

            session.MatchPreview.Team1Players.Clear();
            session.MatchPreview.Team2Players.Clear();

            if (session.WaitingPlayers.Count < 4)
            {
                return;
            }

            string? gameType = GameType;

            if ((gameType == "M" && session.WaitingPlayers[0].Gender != Gender.Male) ||
                (gameType == "F" && session.WaitingPlayers[0].Gender != Gender.Female))
            {
                return;
            }


            int b = 1;
            int c = 1;
            int d = 1;

            int bestMatchScore = int.MaxValue;
            int matchScoreTest = 0;
            var pickedPlayers = new List<int> { 0, 0, 0, 0 };


            for (b = 1; b < session.WaitingPlayers.Count; b++)
            {
                if ((gameType == "M" && session.WaitingPlayers[b].Gender != Gender.Male) ||
                        (gameType == "F" && session.WaitingPlayers[b].Gender != Gender.Female))
                {
                    continue;
                }
                for (c = 1; c < session.WaitingPlayers.Count; c++)
                {
                    if ((gameType == "M" && session.WaitingPlayers[c].Gender != Gender.Male) ||
                        (gameType == "F" && session.WaitingPlayers[c].Gender != Gender.Female))
                    {
                        continue;
                    }
                    for (d = 1; d < session.WaitingPlayers.Count; d++)
                    {
                        if ((gameType == "M" && session.WaitingPlayers[d].Gender != Gender.Male) ||
                          (gameType == "F" && session.WaitingPlayers[d].Gender != Gender.Female))
                        {
                            continue;
                        }
                        if (b != c & b != d & c != d)
                        {
                            if (gameType == "X" && ((session.WaitingPlayers[0].Gender == session.WaitingPlayers[b].Gender) ||
                                (session.WaitingPlayers[c].Gender == session.WaitingPlayers[d].Gender)))
                            {
                                continue;
                            }
                            var TestPlayers = new List<Player> 
                            {
                                session.WaitingPlayers[0], 
                                session.WaitingPlayers[b],
                                session.WaitingPlayers[c], 
                                session.WaitingPlayers[d]
                            };

                            matchScoreTest = MatchScoreTest(TestPlayers, session);

                            if (matchScoreTest < bestMatchScore)
                            {
                                bestMatchScore = matchScoreTest;
                                pickedPlayers = new List<int> { 0, b, c, d};
                            }
                        }
                    }
                }
            }

            if (pickedPlayers.Sum() == 0)
            {
                return;
            }

            var team1player1 = session.WaitingPlayers[pickedPlayers[0]];
            var team1player2 = session.WaitingPlayers[pickedPlayers[1]];
            var team2player1 = session.WaitingPlayers[pickedPlayers[2]];
            var team2player2 = session.WaitingPlayers[pickedPlayers[3]];

            session.MatchPreview.Team1Players.Add(team1player1);
            session.MatchPreview.Team1Players.Add(team1player2);
            session.MatchPreview.Team2Players.Add(team2player1);
            session.MatchPreview.Team2Players.Add(team2player2);

            session.WaitingPlayers.Remove(team1player1);
            session.WaitingPlayers.Remove(team1player2);
            session.WaitingPlayers.Remove(team2player1);
            session.WaitingPlayers.Remove(team2player2);
        }

        public int MatchScoreTest(List<Player> testPlayers, Session session)
        {
            int Score = 0;
            int i = 0;

            var playedWith = testPlayers[0].GetPlayedWith(session);
            var teammateTimes = playedWith.Where(pc => pc.Player == testPlayers[1]).Sum(pc => pc.Count);
            if (teammateTimes > 0)
            {
                Score += 300 * teammateTimes;
            }

            playedWith = testPlayers[2].GetPlayedWith(session);
            teammateTimes = playedWith.Where(pc => pc.Player == testPlayers[3]).Sum(pc => pc.Count);
            if (teammateTimes > 0)
            {
                Score += 300 * teammateTimes;
            }

            var playedAgainst = testPlayers[0].GetPlayedAgainst(session);
            var otherTeamTimes = playedWith.Where(pc => pc.Player == testPlayers[2] || pc.Player == testPlayers[3]).Sum(pc => pc.Count);
            if (otherTeamTimes > 0)
            {
                Score += 75 * otherTeamTimes;
            }

            playedAgainst = testPlayers[1].GetPlayedAgainst(session);
            otherTeamTimes = playedWith.Where(pc => pc.Player == testPlayers[2] || pc.Player == testPlayers[3]).Sum(pc => pc.Count);
            if (otherTeamTimes > 0)
            {
                Score += 75 * otherTeamTimes;
            }

            for (i = 0; i < 4; i++)
            {
                Score -= testPlayers[i].MinutesWaiting * 15;
            }
            Score += Math.Abs((testPlayers[0].Elo + testPlayers[1].Elo) - (testPlayers[2].Elo + testPlayers[3].Elo));
            return Score;
        }
    }
}
