using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    class Game
    {
        Random random = new Random();
        string rPS;
        int computerMove;
        List<int> playerWins = new List<int>();
        List<int> computerWins = new List<int>();

        public Game()
        {
            WelcomeMessage();
            BestOfFive();
            
            
        }
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors Lizard Spock.. \nThis is a best out of 5. \nChoose a move: Rock Paper Scissors Lizard Spock ");

        }

        public void BestOfFive()
        {
           // while (playerWins.Count < 3 | computerWins.Count < 3 )
            //{
                ChooseMove();
                ComputerGenerateMove();
                winOrLose();
           // }
        }

        public void ChooseMove()
        {
            rPS = Console.ReadLine().ToUpper();
        }


        public void ComputerGenerateMove()
        {
            computerMove = random.Next(1,6);
        }


        public void winOrLose()
        {

            if (rPS == "ROCK")
            {
                if (computerMove == 1)
                {
                    Console.WriteLine("Draw! Computer picked Rock");
                }
                else if (computerMove == 2)
                {
                    Console.WriteLine("Winner! Computer picked Scissors");
                    Console.WriteLine(playerWins.Count + "Player wins");
                }
                else if (computerMove == 3)
                {
                    Console.WriteLine("Loser! Computer picked Paper");
                    computerWins.Add(1);
                    Console.WriteLine(playerWins.Count + " Computer Wins");
                }
                else if (computerMove == 4)
                {
                    Console.WriteLine("Winner! Computer picked Lizard");
                    playerWins.Add(1);
                }
                else if (computerMove == 5)
                {
                    Console.WriteLine("Loser! Computer picked Spock");
                    computerWins.Add(1);

                }

            }

            else if (rPS == "PAPER")
            {
                if (computerMove == 1)
                {
                    Console.WriteLine("Draw! Computer picked Paper");
                }
                else if (computerMove == 2)
                {
                    Console.WriteLine("Winner! Computer picked Rock");
                    playerWins.Add(1);

                }
                else if (computerMove == 3)
                {
                    Console.WriteLine("Loser! Computer picked Scissors");
                    computerWins.Add(1);
                }
                else if (computerMove == 4)
                {
                    Console.WriteLine("Winner! Computer picked Spock");
                    playerWins.Add(1);

                }
                else if (computerMove == 5)
                {
                    Console.WriteLine("Loser! Computer picked Lizard");
                    computerWins.Add(1);
                }
            }

            else if (rPS == "SCISSORS")
            {
                if (computerMove == 1)
                {
                    Console.WriteLine("Draw! Computer picked Scissors");
                }
                else if (computerMove == 2)
                {
                    Console.WriteLine("Winner! Computer picked Paper");
                    playerWins.Add(1);

                }
                else if (computerMove == 3)
                {
                    Console.WriteLine("Loser! Computer picked Rock");
                    computerWins.Add(1);

                }
                else if (computerMove == 4)
                {
                    Console.WriteLine("Winner! Computer picked Lizard");
                    playerWins.Add(1);

                }
                else if (computerMove == 5)
                {
                    Console.WriteLine("Loser! Computer picked Spock");
                    computerWins.Add(1);
                }
            }
            else if (rPS == "LIZARD")
            {
                if (computerMove == 1)
                {
                    Console.WriteLine("Draw! Computer picked Lizard");
                }
                else if (computerMove == 2)
                {
                    Console.WriteLine("Winner! Computer picked Paper");
                    playerWins.Add(1);
                }
                else if (computerMove == 3)
                {
                    Console.WriteLine("Loser! Computer picked Scissors");
                    computerWins.Add(1);
                }
                else if (computerMove == 4)
                {
                    Console.WriteLine("Winner! Computer picked Spock");
                    playerWins.Add(1);
                }
                else if (computerMove == 5)
                {
                    Console.WriteLine("Loser! Computer picked Rock");
                    computerWins.Add(1);

                }
            }
            else if (rPS == "SPOCK")
            {
                if (computerMove == 1)
                {
                    Console.WriteLine("Draw! Computer picked Spock");
                }
                else if (computerMove == 2)
                {
                    Console.WriteLine("Winner! Computer picked Scissors");
                    playerWins.Add(1);
                }
                else if (computerMove == 3)
                {
                    Console.WriteLine("Loser! Computer picked Paper");
                    computerWins.Add(1);

                }
                else if (computerMove == 4)
                {
                    Console.WriteLine("Winner! Computer picked Rock");
                    playerWins.Add(1);

                }
                else if (computerMove == 5)
                {
                    Console.WriteLine("Loser! Computer picked Lizard");
                    computerWins.Add(1);

                }
            }
            else
            {
                Console.WriteLine("Wrong output!");
            }
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            if (playerWins.Count < 3 || computerWins.Count < 3)
            {
                Console.WriteLine("Rock, Paper, Scissors, Lizard or Spock?");
            }
            else
            {
                Console.WriteLine("Press enter to exit");
                Console.ReadLine();
                return;
            }

           
            
        }


    }
}
