using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turnBasedRPG
{
    class Difficulty
    {
        enum ChosenDifficulty
        {
            Easy,
            Medium,
            Hard,
            Impossible
        }
        private void difficulty()
        {
            ChosenDifficulty myDifficulty = ChosenDifficulty.Medium;
            switch (myDifficulty)
            {
                case ChosenDifficulty.Easy:
                    Console.WriteLine("Easy difficulty");
                    break;
                case ChosenDifficulty.Medium:
                    Console.WriteLine("Medium difficulty");
                    break;
                case ChosenDifficulty.Hard:
                    Console.WriteLine("Hard difficulty");
                    break;
                case ChosenDifficulty.Impossible:
                    Console.WriteLine("Impossible difficulty");
                    break;
            }
        }
    }
}
