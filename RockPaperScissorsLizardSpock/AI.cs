using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsLizardSpock
{
    public class AI : Player
    {
        //member variables (HAS A)
        Random rng;

        //constructor (SPAWNER)
        public AI()
        {
            rng = new Random();

        }
        //member methods (CAN DO)
        public override void ChooseGesture()
        {
            int gestureRoll = rng.Next(5);
            switch (gestureRoll)
            {
                case 0:
                    gesture = "rock";
                    break;
                case 1:
                    gesture = "paper";
                    break;
                case 2:
                    gesture = "scissors";
                    break;
                case 3:
                    gesture = "lizard";
                    break;
                case 4:
                    gesture = "spock";
                    break;

            }
            Console.WriteLine("Player chose " + gesture + ". Press enter to continue.");
            Console.ReadLine();

        }

    }
}
