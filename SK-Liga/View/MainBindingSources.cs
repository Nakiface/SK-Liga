using SK_Liga.Controller;
using SK_Liga.Model.Base;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SK_Liga.View
{
    public class MainBindingSources
    {
        public BindingSource GameBindingSource { get; set; } = new BindingSource();
        public BindingSource LeagueBindingSource { get; set; } = new BindingSource();

        public MainBindingSources(DataController dataController)
        {
            LoadGameBindingSource(dataController);
        }

        private void LoadGameBindingSource(DataController dataController)
        {
            GameBindingSource.DataSource = dataController.GameList.Select(x => x.Name).ToList();
            ReloadDataSource();
        }

        public void LoadLeagueBindingSource(List<CurrentPlayer> currentPlayers)
        {
            List<CurrentPlayerWithRank> currentPlayerWithRankList = new List<CurrentPlayerWithRank>();
            int i = 1;
            foreach (var currentPlayer in currentPlayers)
            {
                CurrentPlayerWithRank currentPlayerWithRank = new CurrentPlayerWithRank(currentPlayer.Name, currentPlayer.CurrentElo, i);
                currentPlayerWithRankList.Add(currentPlayerWithRank);
                i++;
            }
            LeagueBindingSource.DataSource = currentPlayerWithRankList;
            ReloadDataSource();
        }

        public void ReloadDataSource()
        {
            GameBindingSource.ResetBindings(false);
            LeagueBindingSource.ResetBindings(false);
        }
    }
}
