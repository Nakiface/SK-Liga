using System;
using System.Collections.Generic;

namespace SK_Liga.Model.Base
{
    public class Match
    {
        public List<CurrentPlayer> Winner { get; set; }
        public List<CurrentPlayer> Loser { get; set; }
        public DateTime Date { get; set; }
        public Game Game { get; set; }
        public Match(List<CurrentPlayer> winner, List<CurrentPlayer> loser, Game game)
        {
            this.Winner = winner;
            this.Loser = loser;
            this.Game = game;
            this.Date = DateTime.Now;
        }
    }
}
