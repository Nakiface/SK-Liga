using System.Collections.Generic;

namespace SK_Liga.Model.Base
{
    public class PlayerElos : Player
    {
        public List<GameElo> EloList { get; internal set; }
        public PlayerElos(string playerName, List<GameElo> eloList)
        {
            this.Name = playerName;
            this.EloList = eloList;
        }
    }
}
