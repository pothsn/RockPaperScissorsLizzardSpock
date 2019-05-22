using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsLizardSpock
{
    public class Game
    {
        //member variables (HAS A)
        Player playerOne;
        Player playerTwo;

        //constructor (SPAWNER)

        //member methods (CAN DO)
        public void RunGame()
        {


        }

        public void setGameType()
        {
            Console.WriteLine("Would you like to start a sinlgeplayer, multiplayer or bot vs. bot match?");
            string gameType = Console.ReadLine();
            switch (gameType)
            {
                case "singleplayer":
                    Console.WriteLine("Player one will face a bot.");
                    playerOne = new Human();
                    playerTwo = new AI();
                    break;

                case "multiplayer":
                    Console.WriteLine("Player one will face player two.");
                    playerOne = new Human();
                    playerTwo = new AI();
                    break;

                case "bot vs. bot":
                    Console.WriteLine("An automated bot vs. bot match will play out.");
                    playerOne = new AI();
                    playerTwo = new AI();
                    break;
            }









        }
    }
}
