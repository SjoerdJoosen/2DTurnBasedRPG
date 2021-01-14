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
        private int randomNumber { get; set; }
        public Player(int currentHealth, int maximumHealth) : base(currentHealth, maximumHealth)
        {

        }

        public void DealEnemyDamage()
        {
            randomNumber = PlayerManager.generator.RandomDamageOutput(5, 25);
            PlayerManager.enemy.CurrentHealth = PlayerManager.enemy.CurrentHealth - randomNumber;
            MessageBox.Show($"Player dealt {randomNumber} damage");

            if (PlayerManager.enemy.CurrentHealth <= 0)
            {
                PlayerManager.enemy.CurrentHealth = 0;
                MessageBox.Show("Congratulations, you beat the monster");
            }
        }

        public void ReceivePlayerDamage(bool PlayerIsDefending)
        {
            if (PlayerIsDefending == true)
            {
                randomNumber = PlayerManager.generator.RandomDamageOutput(0, 10);
                PlayerManager.player.CurrentHealth = PlayerManager.player.CurrentHealth - randomNumber;
                MessageBox.Show($"Enemy dealt {randomNumber} damage");
            }

            else { randomNumber = PlayerManager.generator.RandomDamageOutput(5, 25);
                PlayerManager.player.CurrentHealth = PlayerManager.player.CurrentHealth - randomNumber;
                MessageBox.Show($"Enemy dealt {randomNumber} damage");

            }

            if (PlayerManager.player.CurrentHealth <= 0)
            {
                PlayerManager.player.CurrentHealth = 0;
                MessageBox.Show("you are dead, not big surprise");
            }
        }

        public void HealPlayer()
        {
            PlayerManager.player.CurrentHealth = PlayerManager.player.CurrentHealth + PlayerManager.potion.HealthRestored;
            MessageBox.Show($"Player restored {PlayerManager.potion.HealthRestored} Health");

            if (PlayerManager.player.CurrentHealth >= 100)
            {
                PlayerManager.player.CurrentHealth = PlayerManager.player.MaximumHealth;
            }
        }
    }
}
