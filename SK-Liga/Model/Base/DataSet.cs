using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SK_Liga.Model.Base
{
    public class DataSet
    {
        public List<Match> Matches { get; set; }
        public List<PlayerElos> PlayerElos { get; set; }

        public DataSet(List<Match> matches, List<PlayerElos> playerElos)
        {
            this.Matches = matches;
            this.PlayerElos = playerElos;
        }
    }
}
