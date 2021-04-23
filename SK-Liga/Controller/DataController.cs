using SK_Liga.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SK_Liga.Controller
{
    public class DataController
    {
        public List<Match> Matches { get; set; }
        public List<PlayerElos> PlayerElos { get; set; }
        public List<CurrentPlayer> CurrentPlayers { get; set; }
        public List<Game> GameList { get; set; }

        public DataController ()
        {
            LoadData();
        }

        private void LoadData()
        {
            var dataJsonPath = ConfigController.LoadConfig().DataPath;
            DataSet dataSetOrigin = JsonController.Load(dataJsonPath) as DataSet;
            this.Matches = dataSetOrigin.Matches;
            this.PlayerElos = dataSetOrigin.PlayerElos;
            this.GameList = dataSetOrigin.gameList;
        }

        public void CreateCurrentPlayer(Game game)
        {
            List<CurrentPlayer> currentPlayers = new List<CurrentPlayer>();
            foreach (var player in PlayerElos)
            {
                var gameElo = player.EloList.Where(el => el.Game.Equals(game)).FirstOrDefault();
                CurrentPlayer currentPlayer = new CurrentPlayer(player.Name, gameElo.Elo);
            }
            this.CurrentPlayers = currentPlayers;
        }
    }
}
