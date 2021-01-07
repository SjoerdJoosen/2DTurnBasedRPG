using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turnBasedRPG
{
    public class RandomNumber
    {
        /*
        //Fields
        private Random random;

        //Property
        public int RandomDamageNumber { get; set; }


        //Constructor
        public RandomNumber(Random random)
        {
            this.random = random;
        }

        //Method
        public int GenerateRandomDamageNumber()
        {
            this.RandomDamageNumber = random.Next(0, 30);
            return this.RandomDamageNumber;
        } */

        private static Random generator = new Random();

        public int RandomDamageOutput (int minimumValue, int maximumValue)
        {
            return generator.Next(minimumValue, maximumValue + 1);
        }


    }
}

