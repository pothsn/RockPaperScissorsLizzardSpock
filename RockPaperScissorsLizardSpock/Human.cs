using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsLizardSpock
{
    public class Human : Player
    {
        //member variables (HAS A)

        //constructor (SPAWNER)

        //member methods (CAN DO)
        public override void ChooseGesture()
        {
            Console.WriteLine("Choose gesture: Rock, paper, scissors, lizzard or Spock.");
            gesture = Console.ReadLine();
        }

    }
}
