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
    public class Player
    {
        //Encapsulation
        private int randomNumber { get; set; }
        public int CurrentHealth { get; private set; }
        public static string playerName { get; private set; }
        private int MaximumHealth { get; set; }
        
        //Constructor overloading
        public Player(int currentHealth, int maximumHealth)
        {
            CurrentHealth = currentHealth;
            MaximumHealth = maximumHealth;
        }

        public Player(string PlayerName)
        {
            playerName = PlayerName;
        }

        public void DealEnemyDamage()
        {
            randomNumber = PlayerManager.generator.RandomDamageOutput(5, 25);
            PlayerManager.enemy.CurrentHealth = PlayerManager.enemy.CurrentHealth - randomNumber;
            MessageBox.Show($" {playerName} dealt {randomNumber} damage");

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
                MessageBox.Show("Oh no, the monster killed you");
            }
        }

        public void HealPlayer()
        {
            PlayerManager.player.CurrentHealth = PlayerManager.player.CurrentHealth + PlayerManager.potion.HealthRestored;
            MessageBox.Show($" {playerName} restored {PlayerManager.potion.HealthRestored} Health");

            if (PlayerManager.player.CurrentHealth >= 100)
            {
                PlayerManager.player.CurrentHealth = PlayerManager.player.MaximumHealth;
            }
        }
    }
}
