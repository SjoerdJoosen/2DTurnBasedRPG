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
        public static Player player { get; set; }
        public static HealthPotion potion;
        public static Enemy enemy { get; set; }
        public static RandomNumber randomNumber { get; set; }

        public Battlescreen()
        {
            InitializeComponent();
            player = new Player(100, 100);
            enemy = new Enemy(100, 100);
            potion = new HealthPotion(33);
            randomNumber = new RandomNumber();
            
            enemyHP.Text = enemy.CurrentHealth.ToString();
            playerHP.Text = player.CurrentHealth.ToString();
        }

        private void Attack_Click(object sender, EventArgs e)
        {         
            player.DealPlayerDamage();
            enemyHP.Text = enemy.CurrentHealth.ToString();
            player.ReceivePlayerDamage();
            playerHP.Text = player.CurrentHealth.ToString();
        }

        private void Defend_Click(object sender, EventArgs e)
        {
            //player.CurrentHealth = player.CurrentHealth - randomNumber.RandomDamageOutput(0, 15);
            playerHP.Text = player.CurrentHealth.ToString();
        }

        private void UsePotion_Click_1(object sender, EventArgs e)
        {
            player.HealPlayer();
            playerHP.Text = player.CurrentHealth.ToString();

            player.ReceivePlayerDamage();
            playerHP.Text = player.CurrentHealth.ToString();

        }
    }
}
