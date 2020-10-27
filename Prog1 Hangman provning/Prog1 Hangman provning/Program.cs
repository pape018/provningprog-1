using System;

namespace Prog1_Hangman_provning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the game of Hang man");
            string[] ordlsita = new string[3] { "Car", "Reddit", "Donut"};
            string ordet = "hej";
            int antalGissningar = 10;
            Console.WriteLine("Take a guess");

            string gissning = Console.ReadLine();

            if (ordet.Contains(gissning))
            {

            }
            else
            {

            }
        }
    }
}
