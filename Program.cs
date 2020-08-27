using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_08_26_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;
            int scorePlayer = 0;
            int scoreCPU = 0;

            Console.WriteLine("Rock, Paper, Scissors:  ");
            inputPlayer = Console.ReadLine();
            inputPlayer = inputPlayer.ToUpper();

            Random rnd = new Random();

            randomInt = rnd.Next(1, 3);

            switch (randomInt)
            {
                case 1:
                    inputCPU = "ROCK";
                    Console.WriteLine("Computer took ROCK");
                    if (inputPlayer == "ROCK")
                    {
                        Console.WriteLine("Tied\n\n");
                    }
                    else if (inputPlayer == "PAPER")
                    {
                        Console.WriteLine("you win\n\n");
                        scorePlayer++;
                    }
                    else if (inputPlayer == "SCISSORS")
                    {
                        Console.WriteLine("you just got crushed!! CPU wins!!!\n\n");
                        scoreCPU++;
                    }
                    break;
                case 2:
                    inputCPU = "PAPER";
                    Console.WriteLine("Computer took PAPER!");
                    if (inputPlayer == "PAPER")
                    {
                        Console.WriteLine("We have a Tie");
                    }
                    else if (inputPlayer == "ROCK")
                    {
                        Console.WriteLine("you lose\n\n");
                        scoreCPU++;
                    }
                    else if (inputPlayer == "Scissors")
                    
                        Console.WriteLine("you won, you just cut the CPU");
                    scorePlayer++;
                    
                    break;
                case 3:
                    inputCPU = "SCISSORS";
                    break;
                default:

                    break;
            }
        }
    }
}