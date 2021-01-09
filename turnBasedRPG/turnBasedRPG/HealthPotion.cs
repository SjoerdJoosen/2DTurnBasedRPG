using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turnBasedRPG
{
    public class HealthPotion
    {
        public int HealthRestored { get; private set; }

        public HealthPotion(int healthRestored)
        {
            HealthRestored = healthRestored;
        }
    }
}
