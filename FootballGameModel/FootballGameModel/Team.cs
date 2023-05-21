using System;
using System.Collections.Generic;
using System.Text;

namespace FootballGameModel
{
    class Team
    {
        public Coach Coach { get; set; }
        public List<FootballPlayer> Players { get; set; }
        public int AvarageAgeOfPlayers { get; private set; }
        public Team(Coach coach, List<FootballPlayer> players)
        {
            if(players.Count >= 11 && players.Count <= 22)
            {
                Coach = coach;
                Players = players;
                int avAge = 0;
                foreach (FootballPlayer player in Players)
                {
                    avAge += player.Age;
                }
                avAge /= Players.Count;
                AvarageAgeOfPlayers = avAge;
            }
            else
            {
                throw new ArgumentOutOfRangeException("players.count", "A team must have between 11 and 22 players");
            }
        }
    }
}
