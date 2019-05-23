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
            DisplayRules();
            GetNumberOfPlayers();
            SetPlayerNames();
            MakeGesture();
            CompareGesture();


        }

        public void DisplayRules()
        {
            Console.WriteLine("Rock Paper Scissors Lizard Spock is a game based off of Rock Paper Scissors and has a few more rules than the original game." + "\n" + 
                "scissors cuts paper" + "\n" + "paper covers rock" + "\n" + "rock crushes lizard" + "\n" + "lizard poisons spock" + "\n" + "spock smashes scissors" + "\n" +
                "scissors decapitates lizard" + "\n" + "lizard eats paper" + "\n" + "paper disproves spock" + "\n" + "spock vaporizes rock");
            Console.ReadLine();
        }

        public int GetNumberOfPlayers()
        {
            Console.WriteLine("Will the game have one or two players?");
            int numberOfPlayers = int.Parse(Console.ReadLine());
            return numberOfPlayers;
        }

        public void SetPlayerType(int numberOfPlayers)
        {
            if (numberOfPlayers == 1)
            {
                playerOne = new Human();
                playerTwo = new AI();
            }
            else if (numberOfPlayers == 2)
            {
                playerOne = new Human();
                playerTwo = new Human();
            }
            else
            {
                playerOne = new AI();
                playerTwo = new AI();
            }

        }

        public void SetPlayerNames()
        {
            Console.WriteLine("Enter a name for player one.");
            playerOne.name = Console.ReadLine();
            Console.WriteLine("Enter a name for player two.");
            playerTwo.name = Console.ReadLine();
        }

        public void MakeGesture()
        {
            playerOne.ChooseGesture();
            playerTwo.ChooseGesture();
        }

        public void CompareGesture()
        {
            if (playerOne.gesture == playerTwo.gesture)
            {
                Console.WriteLine("Players chose the same gesture for a tie.");
                Console.ReadLine();
                MakeGesture();
            }
            else
            {
                string playerGestures = playerOne.gesture + "vs" + playerTwo.gesture;
                switch (playerGestures)
                {
                    case ("rock vs scissors"):
                        playerOne.score++;
                        break;
                    case ("scissors vs paper"):
                        playerOne.score++;
                        break;
                    case ("paper vs rock"):
                        playerOne.score++;
                        break;
                    case ("rock vs lizard"):
                        playerOne.score++;
                        break;
                    case ("lizard vs spock"):
                        playerOne.score++;
                        break;
                    case ("spock vs scissors"):
                        playerOne.score++;
                        break;
                    case ("scissors vs lizard"):
                        playerOne.score++;
                        break;
                    case ("lizard vs paper"):
                        playerOne.score++;
                        break;
                    case ("paper vs spock"):
                        playerOne.score++;
                        break;
                    case ("spock vs rock"):
                        playerOne.score++;
                        break;

                    case ("scissors vs rock"):
                        playerTwo.score++;
                        break;
                    case ("paper vs scissors"):
                        playerTwo.score++;
                        break;
                    case ("rock vs paper"):
                        playerTwo.score++;
                        break;
                    case ("lizard vs rock"):
                        playerTwo.score++;
                        break;
                    case ("spock vs lizard"):
                        playerTwo.score++;
                        break;
                    case ("scissors vs spock"):
                        playerTwo.score++;
                        break;
                    case ("lizard vs scissors"):
                        playerTwo.score++;
                        break;
                    case ("paper vs lizard"):
                        playerTwo.score++;
                        break;
                    case ("spock vs paper"):
                        playerTwo.score++;
                        break;
                    case ("rock vs spock"):
                        playerTwo.score++;
                        break;
                }

            }
        }









    }
}
