using Badminton.Enums;
using KGySoft.CoreLibraries;
using System.ComponentModel;

namespace Badminton.Classes
{
    public class MatchPicker
    {
        public void PickMatch(string? GameType, Session session, BadmintonClub badmintonClub)
        {
            session.WaitingPlayers.ApplySort(nameof(Player.SecondsWaiting), ListSortDirection.Descending);

            if (session.WaitingPlayers.Count < (4 - (session.MatchPreview.Team1Players.Count + session.MatchPreview.Team2Players.Count))) //Is their enough Players?
            {
                return;
            }

            if (session.MatchPreview.Team1Players.Count == 0)
            {
                if (session.MatchPreview.Team2Players.Count == 0)   // if no picks have happed pick first player from WaitingPlayers
                {
                    session.MatchPreview.Team1Players.Add(session.WaitingPlayers[0]);
                    session.WaitingPlayers.Remove(session.WaitingPlayers[0]);
                }
                else    // If a player/Players has been picked on Team 2 (but not team 1) move them to team one 
                {
                    session.MatchPreview.Team1Players.AddRange(session.MatchPreview.Team2Players);
                    session.MatchPreview.Team2Players.Clear();
                }
            }

            string? gameType = GameType;

            if ((gameType == "M" && session.MatchPreview.Team1Players[0].Gender != Gender.Male) ||          // Has a Female picked a Mens game?
                (gameType == "F" && session.MatchPreview.Team1Players[0].Gender != Gender.Female))          // Has a Male picked a Womens game?
            {
                return;
            }
            int b = 0;      // Initalize 
            int c = 0;
            int d = 0;
            int bestMatchScore = int.MaxValue;      // Best score is Lowest Value, Hence starting value Maxed
            int matchScoreTest = 0;
            var pickedPlayers = new List<int> { 0, 0, 0, 0 };


            for (b = 0; b == 0 || ((b < session.WaitingPlayers.Count) && (session.MatchPreview.Team1Players.Count < 2)); b++)
            {
                for (c = 0; c == 0 || ((c < session.WaitingPlayers.Count) && (session.MatchPreview.Team2Players.Count < 1)); c++)
                {
                    for (d = 0; d == 0 || ((d < session.WaitingPlayers.Count) && (session.MatchPreview.Team2Players.Count < 2)); d++)
                    {
                        var TestPlayers = new List<Player> { session.MatchPreview.Team1Players[0] };	// Fill in TestPlayers either Picked Player or from WaitingPlayers
                        if (session.MatchPreview.Team1Players.Count > 1)
                        {
                            TestPlayers.Add(session.MatchPreview.Team1Players[1]);
                        }
                        else
                        {
                            TestPlayers.Add(session.WaitingPlayers[b]);
                        }
                        if (session.MatchPreview.Team2Players.Count > 0)
                        {
                            TestPlayers.Add(session.MatchPreview.Team2Players[0]);
                        }
                        else
                        {
                            TestPlayers.Add(session.WaitingPlayers[c]);
                        }
                        if (session.MatchPreview.Team2Players.Count > 1)
                        {
                            TestPlayers.Add(session.MatchPreview.Team2Players[1]);
                        }
                        else
                        {
                            TestPlayers.Add(session.WaitingPlayers[d]);
                        }                                                           //Match Selection Testing
                        if (TestPlayers[0] != TestPlayers[1] && TestPlayers[0] != TestPlayers[2] && TestPlayers[0] != TestPlayers[3] &&
                        TestPlayers[1] != TestPlayers[2] && TestPlayers[1] != TestPlayers[3] && TestPlayers[2] != TestPlayers[3])
                        {
                            if ((gameType == "M" && TestPlayers[1].Gender == Gender.Male && TestPlayers[2].Gender == Gender.Male && TestPlayers[3].Gender == Gender.Male) ||
                            (gameType == "F" && TestPlayers[1].Gender == Gender.Female && TestPlayers[2].Gender == Gender.Female && TestPlayers[3].Gender == Gender.Female) ||
                            (gameType == "X" && TestPlayers[0].Gender != TestPlayers[1].Gender && TestPlayers[2].Gender != TestPlayers[3].Gender) ||
                            gameType == null /* Any Gender */)
                            {
                                matchScoreTest = MatchScoreTest(TestPlayers, session, badmintonClub);
                                if (matchScoreTest < bestMatchScore)
                                {
                                    bestMatchScore = matchScoreTest;
                                    pickedPlayers = new List<int> { 0, b, c, d };
                                }
                            }
                        }
                    }
                }
            }

            if (pickedPlayers.Sum() == 0)
            {
                return;
            }
            var RemoveWaitingPlayer = new List<Player> { };
            if (session.MatchPreview.Team1Players.Count < 2)
            {
                session.MatchPreview.Team1Players.Add(session.WaitingPlayers[pickedPlayers[1]]);
                RemoveWaitingPlayer.Add(session.WaitingPlayers[pickedPlayers[1]]);
            }
            if (session.MatchPreview.Team2Players.Count < 1)
            {
                session.MatchPreview.Team2Players.Add(session.WaitingPlayers[pickedPlayers[2]]);
                RemoveWaitingPlayer.Add(session.WaitingPlayers[pickedPlayers[2]]);
            }
            if (session.MatchPreview.Team2Players.Count < 2)
            {
                session.MatchPreview.Team2Players.Add(session.WaitingPlayers[pickedPlayers[3]]);
                RemoveWaitingPlayer.Add(session.WaitingPlayers[pickedPlayers[3]]);
            }
            for (int i = 0; i < RemoveWaitingPlayer.Count;i++)
            {
                session.WaitingPlayers.Remove(RemoveWaitingPlayer[i]);
            }
            session.WaitingPlayers.ApplySort(nameof(Player.SecondsWaiting), ListSortDirection.Descending);
        }

        private int MatchScoreTest(List<Player> testPlayers, Session session, BadmintonClub badmintonClub)
        {
            var settings = badmintonClub.MatchFinderSettings;
            int Score = 0;
            int i = 0;

            var playedWith = testPlayers[0].GetPlayedWith(session);
            var teammateTimes = playedWith.Where(pc => pc.Player == testPlayers[1]).Sum(pc => pc.Count);
            if (teammateTimes > 0)
            {
                Score += 300 * teammateTimes * settings.TeammateWeighting;
            }

            playedWith = testPlayers[2].GetPlayedWith(session);
            teammateTimes = playedWith.Where(pc => pc.Player == testPlayers[3]).Sum(pc => pc.Count);
            if (teammateTimes > 0)
            {
                Score += 300 * teammateTimes * settings.TeammateWeighting;
            }

            var playedAgainst = testPlayers[0].GetPlayedAgainst(session);
            var otherTeamTimes = playedWith.Where(pc => pc.Player == testPlayers[2] || pc.Player == testPlayers[3]).Sum(pc => pc.Count);
            if (otherTeamTimes > 0)
            {
                Score += 75 * otherTeamTimes * settings.OpponentWeighting;
            }

            playedAgainst = testPlayers[1].GetPlayedAgainst(session);
            otherTeamTimes = playedWith.Where(pc => pc.Player == testPlayers[2] || pc.Player == testPlayers[3]).Sum(pc => pc.Count);
            if (otherTeamTimes > 0)
            {
                Score += 75 * otherTeamTimes * settings.OpponentWeighting;
            }

            for (i = 0; i < 4; i++)
            {
                Score -= testPlayers[i].MinutesWaiting * 10 * settings.LastMatchWeighting;
                Score -= testPlayers[i].GetAverageWaitTime(session) * 10 * settings.AverageWaitingWeighting;
            }
            Score += Math.Abs(((testPlayers[0].Elo + testPlayers[1].Elo) - (testPlayers[2].Elo + testPlayers[3].Elo)) * settings.EloTeamVarianceWeighting);

            return Score;
        }
    }
}