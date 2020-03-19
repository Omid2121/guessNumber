using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessNumber
{
    class Program
    {

        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 11);
            int input;
            int numberOfGuesses = 3;
            bool gameOver = false;

            Console.WriteLine("Guess number between 1 & 10 : ");
             

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
                    gameOver = true;
                }
                else if (input > randomNumber)
                    Console.WriteLine("Too heigh, try again.");

                else if (input < randomNumber)
                    Console.WriteLine("Too low, try again. ");
       
            }
            Console.ReadLine();

        }

    }
}
