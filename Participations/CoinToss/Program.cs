using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinToss
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("choose heads or tails");
            string input = Console.ReadLine();
            var rand = new Random();
            var value = rand.Next(0, 2);

            string answer = "";

            if (value == 1)
            {
                answer = "heads";
            }
            else if (value == 0)
            {
                answer = "tails";

            }
                if (input == answer)
                {
                    Console.WriteLine("Congratulations, you guessed correctly");

                }
                else if (input != answer)
                {
                    Console.WriteLine("You suck at guessing");
                }


                Console.ReadKey();




            }
        }
    }
