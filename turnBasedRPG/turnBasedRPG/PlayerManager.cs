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
    public class PlayerManager
    {
        public static Player player { get; private set; }
        public static HealthPotion potion { get; private set; }
        public static Enemy enemy { get; set; }
        public static RandomNumber generator { get; private set; }

        public PlayerManager()
        {
            player = new Player(100, 100);
            potion = new HealthPotion(33);
            generator = new RandomNumber();
        }

        public void Attack()
        {
            player.DealEnemyDamage();
            if (enemy.CurrentHealth > 0)
            {
                player.ReceivePlayerDamage(false);
            }
        }

        public void Defend()
        {
            player.ReceivePlayerDamage(true);
        }

        public void UsePotion()
        {
            player.HealPlayer();
            player.ReceivePlayerDamage(false);
        }

        public void EndGame()
        {
            if (player.CurrentHealth == 0 || enemy.CurrentHealth == 0)
            {
                DifficultySelection difficultySelectionForm = new DifficultySelection();
                Battlescreen.ActiveForm.Hide();
                difficultySelectionForm.Show();
            }
        }
    }
}
