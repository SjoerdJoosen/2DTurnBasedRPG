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
        public static Enemy enemy { get; private set; }
        public static RandomNumber generator { get; private set; }

        public PlayerManager()
        {
            player = new Player(100, 100);
            enemy = new Enemy(100, 100);
            potion = new HealthPotion(33);
            generator = new RandomNumber();
        }

        public void Attack()
        {
            player.DealEnemyDamage();
            player.ReceivePlayerDamage();
        }

        public void Defend()
        {
            player.CurrentHealth = player.CurrentHealth - generator.RandomDamageOutput(0, 15);
            player.ReceivePlayerDamage();
        }

        public void UsePotion()
        {
            player.HealPlayer();
            player.ReceivePlayerDamage();
        }
    }
}
