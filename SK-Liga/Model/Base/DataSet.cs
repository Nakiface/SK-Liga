using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SK_Liga.Model.Base
{
    public class DataSet
    {

        public List<PlayerElos> PlayerElos { get; set; }
        public List<Game> GameList { get; set; }
        public List<Match> Matches { get; set; }


        public DataSet(List<Match> matches, List<PlayerElos> playerElos)
        {
            this.Matches = matches;
            this.PlayerElos = playerElos;
        }
    }
}
