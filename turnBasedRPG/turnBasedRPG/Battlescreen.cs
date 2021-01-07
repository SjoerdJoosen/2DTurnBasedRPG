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
    public partial class Battlescreen : Form
    {
        private Player player;
        private HealthPotion potion;
        private Enemy enemy;
        private RandomNumber randomNumber;

        public Battlescreen()
        {
            InitializeComponent();

            player = new Player(100, 100);
            enemy = new Enemy(100, 100);
            potion = new HealthPotion(33);
            randomNumber = new RandomNumber();

            playerHP.Text = player.CurrentHealth.ToString();
            enemyHP.Text = enemy.CurrentHealth.ToString();
        }

        private void Attack_Click(object sender, EventArgs e)
        {
            enemy.CurrentHealth = enemy.CurrentHealth - randomNumber.RandomDamageOutput(0, 30);
            enemyHP.Text = enemy.CurrentHealth.ToString();
            //MessageBox.Show($"Player dealt { randomNumber.RandomDamageOutput(0, 30) } damage");
            player.CurrentHealth = player.CurrentHealth - randomNumber.RandomDamageOutput(0, 30);
            playerHP.Text = player.CurrentHealth.ToString();
            //MessageBox.Show($"Enemy dealt { randomNumber.RandomDamageOutput(0, 30) } damage");

            if (player.CurrentHealth <= 0)
            {
                player.CurrentHealth = 0;
                playerHP.Text = player.CurrentHealth.ToString();
                MessageBox.Show("you are dead, not big surprise");
                this.Hide();
            }

            else if (enemy.CurrentHealth <= 0)
            {
                enemy.CurrentHealth = 0;
                enemyHP.Text = enemy.CurrentHealth.ToString();
                MessageBox.Show("Congratulations, you beat the monster");
                this.Hide();
            }
        }

        private void Defend_Click(object sender, EventArgs e)
        {
            player.CurrentHealth = player.CurrentHealth - randomNumber.RandomDamageOutput(0, 15);
            playerHP.Text = player.CurrentHealth.ToString();
        }

        private void Potion_Click(object sender, EventArgs e)
        {
            player.CurrentHealth = (player.CurrentHealth + potion.HealthRestored);
            playerHP.Text = player.CurrentHealth.ToString();

            player.CurrentHealth = player.CurrentHealth - randomNumber.RandomDamageOutput(0, 30);
            playerHP.Text = player.CurrentHealth.ToString();

            if (player.CurrentHealth >= 100)
            {
                player.CurrentHealth = player.MaximumHealth;
                playerHP.Text = player.CurrentHealth.ToString();
            }
        }

        private void Battlescreen_Load(object sender, EventArgs e)
        {

        }
    }
}
