using System;
using System.Collections.Generic;

namespace SK_Liga.Model.Base
{
    public class Match
    {
        public List<CurrentPlayer> Winner { get; private set; }
        public List<CurrentPlayer> Loser { get; private set; }
        public DateTime Date { get; private set; }
        public Game Game { get; private set; }
        public Match(List<CurrentPlayer> winner, List<CurrentPlayer> loser, Game game)
        {
            this.Winner = winner;
            this.Loser = loser;
            this.Game = game;
            this.Date = DateTime.Now;
        }
    }
}
