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
            DetermineIfGameWinner();


        }

        public void DisplayRules()
        {
            Console.WriteLine("Rock Paper Scissors Lizard Spock is a game based off of Rock Paper Scissors and has a few more rules than the original game." + "\n" + 
                "scissors cuts paper" + "\n" + "paper covers rock" + "\n" + "rock crushes lizard" + "\n" + "lizard poisons spock" + "\n" + "spock smashes scissors" + "\n" +
                "scissors decapitates lizard" + "\n" + "lizard eats paper" + "\n" + "paper disproves spock" + "\n" + "spock vaporizes rock \n Best two out of three wins the game.");
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
                string playerGestures = playerOne.gesture + " vs " + playerTwo.gesture;
                switch (playerGestures)
                {
                    case ("rock vs scissors"):
                    case ("scissors vs paper"):                   
                    case ("paper vs rock"):
                    case ("rock vs lizard"):
                    case ("lizard vs spock"):
                    case ("spock vs scissors"):
                    case ("scissors vs lizard"):
                    case ("lizard vs paper"):
                    case ("paper vs spock"):
                    case ("spock vs rock"):
                        Console.WriteLine(playerOne.name + " has won the round.");
                        Console.ReadLine();
                        playerOne.score++;
                        break;

                    case ("scissors vs rock"):
                    case ("paper vs scissors"):
                    case ("rock vs paper"):
                    case ("lizard vs rock"):
                    case ("spock vs lizard"):
                    case ("scissors vs spock"):
                    case ("lizard vs scissors"):
                    case ("paper vs lizard"):
                    case ("spock vs paper"):
                    case ("rock vs spock"):
                        Console.WriteLine(playerTwo.name + " wins the round.");
                        Console.ReadLine();
                        playerTwo.score++;
                        break;
                }

            }
        }

        public void DetermineIfGameWinner()
        {
            if(playerOne.score > 1)
            {
                Console.WriteLine(playerOne.name + " has won the game! Would you like to reset the game? Input: Yes or no.");
                string replay = Console.ReadLine();
                if(replay == "yes")
                {
                    RunGame();
                }
                else
                {
                    return;
                }
            }
            else if(playerTwo.score > 1)
            {
                Console.WriteLine(playerTwo.name + " has won the game! Would you like to reset the game? Input: Yes or no.");
                string replay = Console.ReadLine();
                if (replay == "yes")
                {
                    RunGame();
                }
                else
                {
                    return;
                }
            }
            else
            {
                GameRoundLoop();
            }
        }
        public void GameRoundLoop()
        {
            MakeGesture();
            CompareGesture();
            DetermineIfGameWinner();
        }








    }
}
