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
            foreach (string gesture in gestures)
            {
                Console.WriteLine(gesture);
            }
            gesture = Console.ReadLine();
            Console.WriteLine("Player chose " + gesture + ". Press enter to continue.");
            Console.ReadLine();
        }

    }
}
