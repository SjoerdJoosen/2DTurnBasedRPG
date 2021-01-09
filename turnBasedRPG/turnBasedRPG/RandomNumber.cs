using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turnBasedRPG
{
    public class RandomNumber
    {
        private static Random generator = new Random();

        public int RandomDamageOutput (int minimumValue, int maximumValue)
        {
            return generator.Next(minimumValue, maximumValue + 1);
        }
    }
}

