using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turnBasedRPG
{
    public class RandomNumber
    {
        private readonly Random random = new Random();

        public int RandomDamageOutput (int minimumDamage, int maximumDamage)
        {
            return random.Next(minimumDamage, maximumDamage);
        }
    }
}

