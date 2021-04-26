using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SK_Liga.Model.Base
{
    public class CurrentPlayer
    {
        public int CurrentElo { get; protected set; }
        public string Name { get; protected set; }

        public void Load (PlayerElos playerElos , string gameName)
        {
            this.Name = CreatePlayerName(playerElos);
            this.CurrentElo = CreateElo(playerElos, gameName);
        }

        private int CreateElo(PlayerElos playerElos, string gameName)
        {
            return playerElos.EloList.Where(x => x.Game.Name == gameName).FirstOrDefault().Elo;
        }

        private string CreatePlayerName(PlayerElos playerElos)
        {
            return playerElos.Name;
        }
    }
}
