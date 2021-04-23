using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SK_Liga.Model.Base
{
    public class CurrentPlayer : Player
    {
        public int CurrentElo { get; private set; }
        public CurrentPlayer (string playerName, int currentElo)
        {
            this.Name = playerName;
            this.CurrentElo = currentElo;
        }
    }
}
