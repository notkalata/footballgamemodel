using System;
using System.Collections.Generic;
using System.Text;

namespace FootballGameModel
{
    class Game
    {
        public Team Team1 { get; private set; }
        public Team Team2 { get; private set; }
        public Referee Referee { get; private set; }
        public List<Referee> AssistantReferees { get; private set; }
        private Dictionary<int, FootballPlayer> Goals = new Dictionary<int, FootballPlayer>();
        private int Team1Goals = 0;
        private int Team2Goals = 0;

        public Game(Team team1, Team team2, Referee referee, List<Referee> assistantReferees)
        {
            if (team1.Players.Count != 11 || team2.Players.Count != 11)
            {
                throw new ArgumentOutOfRangeException("team.player.count", "Both teams must have 11 people to play with.");
            }
            Team1 = team1;
            Team2 = team2;
            Referee = referee;
            if (assistantReferees.Count != 2)
            {
                throw new ArgumentOutOfRangeException("assistantReferees.count", "The assistant referees must be exactly 2.");
            }
            AssistantReferees = assistantReferees;
        }

        public void AddGoal(int minute, FootballPlayer player) {
            Goals.Add(minute, player);
            if (Team1.Players.Contains(player))
            {
                Team1Goals += 1;
            }
            else if (Team2.Players.Contains(player)){
                Team2Goals += 1;
            }
        }

        public void GetGameResult()
        {
            Console.WriteLine($"{Team1Goals} - {Team2Goals}");
            if(Team1Goals > Team2Goals)
            {
                Console.WriteLine("TEAM 1 WINS!");
            }
            else if(Team1Goals < Team2Goals)
            {
                Console.WriteLine("TEAM 2 WINS!");
            }
            else
            {
                Console.WriteLine("DRAW");
            }
        }
    }
}
