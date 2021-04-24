using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SK_Liga.Model.Base
{
    public class CurrentPlayer
    {
        public int CurrentElo { get; private set; }
        public string Name { get; set; }

        public void Load (PlayerElos playerElos , Game game)
        {
            this.Name = CreatePlayerName(playerElos);
            this.CurrentElo = CreateElo(playerElos, game);
        }

        private int CreateElo(PlayerElos playerElos, Game game)
        {
            return playerElos.EloList.Where(x => x.Game.Equals(game)).FirstOrDefault().Elo;
        }

        private string CreatePlayerName(PlayerElos playerElos)
        {
            return playerElos.Name;
        }
    }
}
