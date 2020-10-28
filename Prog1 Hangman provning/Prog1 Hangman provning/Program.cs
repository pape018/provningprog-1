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

            //Koder för att spelet skall börja komma igång.
            //För att kunna slumpa tal, blanda ord så att det inte alltid samma ord.
            Random random = new Random();
            int slumpTal = random.Next(ordlista.Length);
            string ord = ordlista[slumpTal];
            char[] snabelof = new char[ord.Length];


            //För varje bokstav det finns en @.
            //@ finns lika mycket som bokstäver i orden.
            //Max gissningar man får göra är 10 stycken. 
            for (int i = 0; i < snabelof.Length; i = i +1)
            {
                snabelof[i] = '@';
            }

            int antalGissningar = 10;

            //Spelet börjar med att spelaren skall välja bokstäver.
            //@ uppkommer efter första gissningen. 
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

                    string name = new string(snabelof);

                    //Om ordet innehåller @ så gissar man tills det ingen @ kvar.
                    if (name.Contains("@"))
                    {
                        continue;
                    }

                    //När ordet är uppfylld så har spelaren vunnit spelen.
                    //Break är för att avsluta eller stanna spelet eftersom det är klart.
                    else
                    {
                        Console.WriteLine("You have won the game!");
                        Console.WriteLine("Wanna play again? It is fun");
                        break;
                    }
                }

                //När spelaren inte gissar bokstav rätt så minskar antal gissningar med -1.
                //När det inga gissningar kvar så har spelaren förlorat spelet. 
                else
                {
                    Console.WriteLine("Wrong guess, try again!");
                    antalGissningar = antalGissningar -1;
                    Console.WriteLine("You have: " + antalGissningar + " left!");
                    
                }

            } while (antalGissningar > 0);

            //Spelet frågar om man vill spela igen.
            Console.WriteLine("Wanna paly again?");
            

        }
    }
}
