using System.Collections.Generic;

namespace SK_Liga.Model.Base
{
    public class PlayerElos
    {
        public List<GameElo> EloList { get; set; }
        public string Name { get; set; }
        public PlayerElos(string playerName, List<GameElo> eloList)
        {
            this.Name = playerName;
            this.EloList = eloList;
        }
    }
}
