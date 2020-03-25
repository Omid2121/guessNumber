using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace guessNumber
{
    class Program
    {
        public static Random random = new Random();
        public static int winStreak = 1;


        static void Main(string[] args)
        {
            
            while(true)
            {
                

                Mitspil();
                Console.ReadLine();
            }
            

        }

        public static void Mitspil()
        {
            Console.WriteLine("Guess number between 1 & 10 : ");
            
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
                    Console.WriteLine("Your Winsteak is " + winStreak);
                    winStreak++;

                    WriteHighScore(winStreak);





                    Console.WriteLine("Do you want to play again?(yes or no)");
                    string restart = Console.ReadLine();
                    if (restart == "no")
                    {
                        gameOver = true;
                    }
                    else if (restart == "yes")
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

        static void WriteHighScore(int score) //skriv i fil.
        {
            try
            {
                File.WriteAllText(@"C:\Users\omidh\Documents\score.text", String.Empty);
                File.WriteAllText(@"C:\Users\omidh\Documents\score.text", score.ToString());
            }
            catch (Exception e) { Console.WriteLine(e); }
            
        }

        static string ReadHighScore() //læs fra fil.
        {
            try
            {
                return File.ReadAllText(@"C:\Users\omidh\Documents");
            }
            catch (Exception)
            {
                return "-1";
              
            }
        }
    }

}
