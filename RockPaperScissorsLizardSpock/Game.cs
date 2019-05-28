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
            int players = GetNumberOfPlayers();
            SetPlayerType(players);
            SetPlayerNames();

            while(NoWinnerYet())
            {
                GameRoundLoop();
            }

            DetermineIfRestart();
        }

        public void GameRoundLoop()
        {
            MakeGesture();
            while (GesturesAreSame())
            {
                MakeGesture();
            }
            CompareGesture();
        }

        public void DisplayRules()
        {
            Console.WriteLine("Rock Paper Scissors Lizard Spock is a game based off of Rock Paper Scissors, with two added gestures." + "\n" +  "Rules:" + "\n" + 
                "scissors cuts paper" + "\n" + "paper covers rock" + "\n" + "rock crushes lizard" + "\n" + "lizard poisons Spock" + "\n" + "Spock smashes scissors" + "\n" +
                "scissors decapitates lizard" + "\n" + "lizard eats paper" + "\n" + "paper disproves Spock" + "\n" + "Spock vaporizes rock" + "\n" + "Best two out of three wins the game, press Enter to begin.");
            Console.ReadLine();
        }

        public int GetNumberOfPlayers()
        {

            Console.WriteLine("Will the game have one or two players? Enter 1 or 2. For bot vs bot match, enter 0.");
            try
            {
                int numberOfPlayers = int.Parse(Console.ReadLine());
                if(numberOfPlayers == 0 || numberOfPlayers == 1 || numberOfPlayers == 2)
                {
                    return numberOfPlayers;
                }
                else
                {
                    return GetNumberOfPlayers();
                }
            }
            catch
            {
                return GetNumberOfPlayers();
            }
           
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
            Console.WriteLine("Player one choose gesture: ");
            playerOne.ChooseGesture();
            Console.WriteLine("Player two choose gesture: ");
            playerTwo.ChooseGesture();
        }

        public bool GesturesAreSame()
        {
         if (playerOne.gesture == playerTwo.gesture)
         {
             Console.WriteLine("Players chose the same gesture for a tie. Press Enter to continue.");
             Console.ReadLine();
             return true;
         }
         else
         {
             return false;
         }

        }
        public void CompareGesture()
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
                    Console.WriteLine(playerOne.name + " has won the round. Press Enter to continue.");
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
                    Console.WriteLine(playerTwo.name + " wins the round. Press enter to continue.");
                    Console.ReadLine();
                    playerTwo.score++;
                    break;
            }

        }

        public bool NoWinnerYet()
        {
            if(playerOne.score > 1)
            {
                Console.WriteLine(playerOne.name + " has won the game! Press Enter to continue.");
                Console.ReadLine();
                return false;
            }
            else if(playerTwo.score > 1)
            {
                Console.WriteLine(playerTwo.name + " has won the game! Press enter to continue.");
                Console.ReadLine();
                return false;
            }
            else
            {
                return true;
            }
        }
       
        public void DetermineIfRestart()
        {
            Console.WriteLine("Would you like to restart the game? Enter: Yes or no.");
            string yesNo = Console.ReadLine().ToLower();
           
                switch (yesNo)
                {
                    case "yes":
                        RunGame();
                        break;
                    case "no":
                        break;
                    default:
                        Console.WriteLine("Invalid input.");
                        DetermineIfRestart();
                        break;

                }
         
        }

    }
}
