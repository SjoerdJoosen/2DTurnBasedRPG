using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turnBasedRPG
{
    class HealthPotion
    {
        public int HealthRestored { get; set; }

        public HealthPotion(int healthRestored)
        {
            HealthRestored = healthRestored;
        }

        //player.CurrentHealth = (player.CurrentHealth + potion.HealthRestored);
        //playerHP.Text = player.CurrentHealth.ToString();
    }
}
