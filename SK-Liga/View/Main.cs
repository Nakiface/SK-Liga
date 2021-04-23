using SK_Liga.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SK_Liga.View
{
    public static class MainController
    {
        public static DataController LoadDataController()
        {
            DataController dataController = new DataController();
            return dataController;
        }
    }

    public class MainBindingSources
    {
        public BindingSource GameBindingSource { get; set; }
        public BindingSource LeagueBindingSource { get; set; }

        public MainBindingSources(DataController dataController)
        {
            LoadGameBindingSource(dataController);
        }

        private void LoadGameBindingSource(DataController dataController)
        {
            GameBindingSource.DataSource = dataController.GameList.Select(x => x.Name).ToList();
            GameBindingSource.ResetBindings(false);
        }
    }

    public partial class Main : Form
    {
        private DataController _dataController;
        private MainBindingSources _bindingSources;
        public Main()
        {
            InitializeComponent();
            InitializeVariables();
            InitializeComboCox();
        }

        private void InitializeVariables()
        {
            this._dataController = MainController.LoadDataController();
            this._bindingSources = new MainBindingSources(_dataController);       
        }

        private void InitializeComboCox()
        {
            comboBoxGame.DataSource = _bindingSources.GameBindingSource;
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
