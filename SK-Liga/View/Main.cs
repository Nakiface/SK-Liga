using SK_Liga.Controller;
using SK_Liga.Model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SK_Liga.View
{
    public partial class Main : Form
    {
        private DataController _dataController;
        private MainBindingSources _bindingSources;
        private List<CurrentPlayer> playerList;

        public Main()
        {
            InitializeComponent();
            InitializeVariables();
            InitializeBindings();
        }

        private void InitializeVariables()
        {
            this._dataController = MainController.LoadDataController();
            this._bindingSources = new MainBindingSources(_dataController);       
        }

        private void InitializeBindings()
        {
            comboBoxGame.DataSource = _bindingSources.GameBindingSource;
            _bindingSources.LoadLeagueBindingSource(MainController.LoadCurrentPlayer(_dataController, comboBoxGame.SelectedItem.ToString()));
            dataGridViewLeague.DataSource = _bindingSources.LeagueBindingSource;
        }

        private void buttonRecord_Click(object sender, EventArgs e)
        {

        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {

        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {

        }
    }
}
