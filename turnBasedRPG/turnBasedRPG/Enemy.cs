using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turnBasedRPG
{
    public class Enemy
    {
        public int CurrentHealth { get; set; }
        public int MaximumHealth { get; set; }

        public Enemy(int currentHealth, int maximumHealth)
        {
            CurrentHealth = currentHealth;
            MaximumHealth = maximumHealth;
        }
    }
}
