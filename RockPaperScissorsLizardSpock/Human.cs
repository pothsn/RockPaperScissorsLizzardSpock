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
        public override string ChooseGesture()
        {
            foreach (string gesture in gestures)
            {
                Console.WriteLine(gesture);
            }
            gesture = Console.ReadLine().ToLower();
            if (gesture == "rock" || gesture == "paper" || gesture == "scissors" || gesture == "lizard" || gesture == "spock")
            {
                Console.WriteLine("Player chose " + gesture + ". Press enter to continue.");
                Console.ReadLine();
                return gesture;
            }
            else
            {
                Console.WriteLine("Invalid input! Choose from:");
                return ChooseGesture();
            }
        }

    }
}
