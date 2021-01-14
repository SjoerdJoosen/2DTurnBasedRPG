using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace turnBasedRPG
{
    public partial class DifficultySelection : Form
    {
        public DifficultySelection()
        {
            InitializeComponent();
        }


        private void GoToBattlescreen_Click(object sender, EventArgs e)
        {
            string name = PlayerNameBox.Text;
            PlayerName nameOfPlayer = new PlayerName(name);
            Battlescreen BattlescreenForm = new Battlescreen(nameOfPlayer);
            BattlescreenForm.Show();
            this.Hide();
        }

        private void cb_DifficultySelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cb_DifficultySelect.DataSource = Enum.GetValues(typeof(Difficulty.ChosenDifficulty));
        }
    }
}
