using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turnBasedRPG
{
    public class Difficulty
    {
        private int SelectedIndex;
        public Difficulty(int ChosenDifficulty)
        {
            SelectedIndex = ChosenDifficulty;
            ChosenDifficulty chosenDifficulty = (ChosenDifficulty)SelectedIndex;
            SelectedDifficulty(chosenDifficulty);
        }
        
        public enum ChosenDifficulty
        {
            Easy,
            Medium,
            Hard,
            Impossible
        }

        //Method with own type as parameters
        public static void SelectedDifficulty(Enum myDifficulty)
        {
            switch (myDifficulty)
            {
                case ChosenDifficulty.Easy:
                    PlayerManager.enemy = new Enemy(50, 50);
                    
                    break;
                case ChosenDifficulty.Medium:
                    PlayerManager.enemy = new Enemy(100, 100);

                    break;
                case ChosenDifficulty.Hard:
                    PlayerManager.enemy = new Enemy(150, 150);

                    break;
                case ChosenDifficulty.Impossible:
                    PlayerManager.enemy = new Enemy(200, 200);

                    break;
            }
        }
    }
}
