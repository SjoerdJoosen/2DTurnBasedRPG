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
    
    public class Player : LivingCreatures
    {
        private Player player;
        private HealthPotion potion;
        private Enemy enemy;
        private RandomNumber randomNumber;

        public Player(int currentHealth, int maximumHealth) : base (currentHealth, maximumHealth)
        {

        }

        /*public void DealPlayerDamage()
        {
            player = new Player(100, 100);
            enemy = new Enemy(100, 100);
            potion = new HealthPotion(33);
            randomNumber = new RandomNumber();

            playerHP.Text = player.CurrentHealth.ToString();
            enemyHP.Text = enemy.CurrentHealth.ToString();

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
                MessageBox.Show("Congratulations, you beat tha monstah");
                this.Hide();
            }
        }*/

        public void ReceiveDamage()
        {

        }

        
    }
}
