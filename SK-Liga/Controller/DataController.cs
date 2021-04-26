using SK_Liga.Model.Base;
using SK_Liga.Model.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SK_Liga.Controller
{
    public class DataController
    {
        public List<Match> Matches { get; set; } = new List<Match>();
        public List<PlayerElos> PlayerElos { get; set; } = new List<PlayerElos>();
        public List<CurrentPlayer> CurrentPlayers { get; set; } = new List<CurrentPlayer>();
        public List<Game> GameList { get; set; } = new List<Game>();

        public DataController ()
        {
            LoadData();
        }

        private void LoadData()
        {
            var config = ConfigController.LoadConfig();
            DataSet dataSetOrigin = JsonController.LoadData(config.DataPath);
            this.Matches = dataSetOrigin.Matches;
            this.PlayerElos = dataSetOrigin.PlayerElos;
            this.GameList = dataSetOrigin.GameList;
        }

        public void CreateCurrentPlayer(string gameName)
        {
            List<CurrentPlayer> currentPlayers = new List<CurrentPlayer>();
            foreach (var player in PlayerElos)
            {
                var gameElo = player.EloList.Where(el => el.Game.Name == gameName).FirstOrDefault();
                CurrentPlayer currentPlayer = new CurrentPlayer();
                currentPlayer.Load(player, gameName);
            }
            this.CurrentPlayers = currentPlayers;
        }

        public static void CreateFirstDataSetJson()
        {
            Game game = new Game("dummyGame");
            GameElo gameElo1 = new GameElo(game, 1000);
            GameElo gameElo2 = new GameElo(game, 500);

            PlayerElos playerElosDummy1 = new PlayerElos("Dummy", new List<GameElo>() { gameElo1 });
            PlayerElos playerElosDummy2 = new PlayerElos("Dummy2", new List<GameElo>() { gameElo2 });

            CurrentPlayer currentPlayer1 = new CurrentPlayer();
            currentPlayer1.Load(playerElosDummy1, game.Name);
            CurrentPlayer currentPlayer2 = new CurrentPlayer();
            currentPlayer2.Load(playerElosDummy2, game.Name);

            Match match = new Match(new List<CurrentPlayer>() { currentPlayer1 }, new List<CurrentPlayer>() { currentPlayer2 }, game);

            DataSet dataSet = new DataSet(new List<Match>() { match }, new List<PlayerElos>() { playerElosDummy1, playerElosDummy2 });

            Config config = ConfigController.LoadConfig();
            JsonController.Save(config.DataPath, dataSet);
        }
    }
}
