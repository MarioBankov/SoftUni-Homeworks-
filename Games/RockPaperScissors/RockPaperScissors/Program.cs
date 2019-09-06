using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string imputPlayer, imputCUP;
            int randomInt;
            int playerScore = 0;
            int CPUScore = 0;
            bool next = true;

            while (next)
            {
                while (playerScore < 3 && CPUScore < 3)
                {
                    Console.Write("Choose Rock,Paper or Scissors       ");
                    imputPlayer = Console.ReadLine().ToLower();

                    Random rnd = new Random();
                    randomInt = rnd.Next(1, 4);
                    // 1-rock 2-papaer 3-scissors
                    switch (randomInt)
                    {
                        case 1:
                            imputCUP = "rock";
                            Console.WriteLine("Computer Chose ROCK");
                            if (imputPlayer == "rock")
                            {

                                Console.Write("\t\t\t\t\tDRAW! \n\n");
                                Console.Write("Player score: {0} CUP score {1}\t", playerScore, CPUScore);
                            }
                            else if (imputPlayer == "paper")
                            {

                                Console.Write("\t\t\t\t\tPlayer Wins! \n\n");
                                playerScore++;
                                Console.Write("Player score: {0} CUP score {1}\t", playerScore, CPUScore);
                                
                            }
                            else if (imputPlayer == "scissors")
                            {
                                Console.Write("\t\t\t\t\tCPU WINS! \n\n");
                                CPUScore++;
                                Console.Write("Player score: {0} CUP score {1}\t", playerScore, CPUScore);
                             
                            }
                            break;
                        case 2:
                            imputCUP = "paper";
                            Console.WriteLine("Computer Chose PAPER");
                            if (imputPlayer == "paper")
                            {
                                Console.Write("\t\t\t\t\tDRAW! \n\n");
                                Console.Write("Player score: {0} CUP score {1}\t", playerScore, CPUScore);
                            }
                            else if (imputPlayer == "rock")
                            {
                                Console.Write("\t\t\t\t\tCPU WINS! \n\n");
                                CPUScore++;
                                Console.Write("Player score: {0} CUP score {1}\t", playerScore, CPUScore);
                              
                            }
                            else if (imputPlayer == "scissors")
                            {
                                Console.Write("\t\t\t\t\t Player Wins! \n\n");
                                playerScore++;
                                Console.Write("Player score: {0} CUP score {1}\t", playerScore, CPUScore);
                               
                            }
                            break;
                        case 3:
                            imputCUP = "scissors";
                            Console.WriteLine("Computer Chose Scissors");
                            if (imputPlayer == "scissors")
                            {
                                Console.Write(" \t\t\t\t\tDRAW! \n\n");
                                Console.Write("Player score: {0} CUP score {1}\t", playerScore, CPUScore);
                            }
                            else if (imputPlayer == "rock")
                            {
                                Console.Write("\t\t\t\t\tPlayer Wins! \n\n");
                                playerScore++;
                                Console.Write("Player score: {0} CUP score {1}\t", playerScore,CPUScore);
                             
                            }
                            else if (imputPlayer == "paper")
                            {
                                Console.Write("\t\t\t\t\tCPU WINS! \n\n");
                                CPUScore++;
                                Console.Write("Player score: {0} CUP score {1}\t", playerScore, CPUScore);
                                
                            }
                            break;

                    }
                }
                Console.WriteLine("Player score: {0} CUP score {1}", playerScore, CPUScore);
                Console.WriteLine("one more game ?");
                Console.WriteLine("type Yes  or No");
                string yesNo = Console.ReadLine();
                if (yesNo.ToLower()=="yes")
                {
                    next = true;
                }
                else if (yesNo.ToLower()=="no")
                {
                    next = false;
                }
                
            }
        }
    }
}
