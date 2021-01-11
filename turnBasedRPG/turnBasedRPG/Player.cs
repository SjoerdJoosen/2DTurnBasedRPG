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
        public int randomNumber { get; private set; }
        public Player(int currentHealth, int maximumHealth) : base (currentHealth, maximumHealth)
        {

        }

        public void DealEnemyDamage()
        {
            randomNumber = PlayerManager.generator.RandomDamageOutput(0, 30);
            PlayerManager.enemy.CurrentHealth = PlayerManager.enemy.CurrentHealth - randomNumber;
            MessageBox.Show($"Player dealt {randomNumber} damage");

            if (PlayerManager.enemy.CurrentHealth <= 0)
            {
                PlayerManager.enemy.CurrentHealth = 0;
                MessageBox.Show("Congratulations, you beat the monster");             
            }
        }

        public void ReceivePlayerDamage()
        {
            randomNumber = PlayerManager.generator.RandomDamageOutput(0, 30);
            PlayerManager.player.CurrentHealth = PlayerManager.player.CurrentHealth - randomNumber;
            MessageBox.Show($"Enemy dealt {randomNumber} damage");

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
