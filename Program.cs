using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessNumber
{
    class Program
    {
        public static Random random = new Random();

        static void Main(string[] args)
        {
            
            while(true)
            {
                Console.WriteLine("Guess number between 1 & 10 : ");
                Mitspil();
                Console.ReadLine();
            }
            

        }

        public static void Mitspil()
        {
            
            int randomNumber = random.Next(1, 11);
            int input;
            int numberOfGuesses = 3;
            bool gameOver = false;

            while (gameOver == false)
            {
                input = Convert.ToInt32(Console.ReadLine());
                numberOfGuesses--;

                if (input != randomNumber && numberOfGuesses == 0)
                {
                    Console.WriteLine("Game over for you!");
                    gameOver = true;
                }
                else if (input == randomNumber)
                {
                    Console.WriteLine("You win!!");

                    Console.WriteLine("Do you want to play again?(yes or no)");
                    string restart = Console.ReadLine();
                    if (restart == "no")
                    {
                        
                    }
                    else
                    {
                        Mitspil();
                    }
                }
                else if (input > randomNumber)
                    Console.WriteLine("Too heigh, try again.");

                else if (input < randomNumber)
                    Console.WriteLine("Too low, try again. ");

            }
            
        }

    }

}
