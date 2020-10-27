using System;
using System.Threading;

namespace Prog1_Hangman_provning
{
    class Program
    {
        static void Main(string[] args)
        {
            //Börja med att välkomna spelaren till spelet. 
            //Hitta ord och skriva ut med string.
            Console.WriteLine("Welcome to the game of Hang man");
            string[] ordlista = new string[3] { "Car", "Key", "Song" };

            Random random = new Random();
            int slumpTal = random.Next(ordlista.Length);
            string ord = ordlista[slumpTal];
            char[] snabelof = new char[ord.Length];
            
            for (int i = 0; i < snabelof.Length; i = i +1)
            {
                snabelof[i] = '@';
            }

            int antalGissningar = 10;

            do

            {
                Console.WriteLine("Tage a guess!");
                string gissning = Console.ReadLine();

                if (ord.Contains(gissning))
                {
                    char[] ordChars = ord.ToCharArray();

                    for (int i = 0; i < ordChars.Length; i++)
                    {
                        if (gissning.ToCharArray()[0] == ordChars[i])
                        {
                            snabelof[i] = gissning.ToCharArray()[0];
                        }
                    }

                    Console.WriteLine(snabelof);

                    string starWord = new string(snabelof);

                    if (starWord.Contains("@"))
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("You have won the game!");
                        Console.WriteLine("Wanna play again? It is fun");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Wrong guess, try again!");
                    antalGissningar--;
                    Console.WriteLine("You have: " + antalGissningar + " left!");
                   
                }
            } while (antalGissningar > 0);
            Console.WriteLine("Wanna paly again?");
            

        }
    }
}
