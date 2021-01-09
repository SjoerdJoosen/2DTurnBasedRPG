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
/*        public int CurrentHealth { get; private set; }
        public int MaximumHealth { get; private set; }*/

        public Player(int currentHealth, int maximumHealth) : base (currentHealth, maximumHealth)
        {
            CurrentHealth = currentHealth;
            MaximumHealth = maximumHealth;
        }

        public void DealPlayerDamage()
        {
            Battlescreen.enemy.CurrentHealth = Battlescreen.enemy.CurrentHealth - Battlescreen.randomNumber.RandomDamageOutput(0, 30);

            if (Battlescreen.enemy.CurrentHealth <= 0)
            {
                Battlescreen.enemy.CurrentHealth = 0;
                MessageBox.Show("Congratulations, you beat the monster");
                
            }
        }

        public void ReceivePlayerDamage()
        {
            Battlescreen.player.CurrentHealth = Battlescreen.player.CurrentHealth - Battlescreen.randomNumber.RandomDamageOutput(0, 30);

            if (Battlescreen.player.CurrentHealth <= 0)
            {
                Battlescreen.player.CurrentHealth = 0;
                MessageBox.Show("you are dead, not big surprise");
            }
        }
        
        public void HealPlayer()
        {
            Battlescreen.player.CurrentHealth = Battlescreen.player.CurrentHealth + Battlescreen.potion.HealthRestored;

            if (Battlescreen.player.CurrentHealth >= 100)
            {
                Battlescreen.player.CurrentHealth = Battlescreen.player.MaximumHealth;
            }
        }
    }
}
