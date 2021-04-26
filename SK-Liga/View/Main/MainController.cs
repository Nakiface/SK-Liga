using SK_Liga.Controller;
using SK_Liga.Model.Base;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SK_Liga.View
{
    public static class MainController
    {
        public static DataController LoadDataController()
        {
            DataController dataController = new DataController();
            return dataController;
        }

        public static List<CurrentPlayer> LoadCurrentPlayer(DataController dataController, string gameName)
        {
            List<CurrentPlayer> currentPlayerList = new List<CurrentPlayer>();
            foreach (var player in dataController.PlayerElos)
            {
                CurrentPlayer currentPlayer = new CurrentPlayer();
                currentPlayer.Load(player, gameName);
                currentPlayerList.Add(currentPlayer);
            }
            currentPlayerList.OrderByDescending(x => x.CurrentElo);
            return currentPlayerList;
        }
    }
}
