using System;
using System.Collections.Generic;

namespace Tarot_Reader___Side_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"\t\t\t*.*.*Hello and welcome*.*.*" +
                $"              \n\t\t ~~Would you like a Tarot Reading?~~");

            string doTheyWantAReading = Console.ReadLine();
            
            if(doTheyWantAReading.ToLower()=="yes")
            {
                Console.WriteLine($"\t\t\tWonderful! Let's start you off with a three card reading.");
                Console.ReadLine();
                Console.WriteLine($"\t \t\t Take a deep breath and focus on the question you would like answered. When you're ready press enter.");
                Console.ReadLine();
                Console.WriteLine($"Shuffling deck");

                List<string> majorArcana = new List<string>()
                {
                    "THE FOOL", "THE MAGICIAN", "THE HIGH PRIESTESS",
                    "THE EMPRESS", "THE EMPEROR", "THE HEIROPHANT",
                    "THE LOVERS", "THE CHARIOT", "STRENGTH",
                    "THE HERMIT", "WHEEL OF FORTUNE", "JUSTICE",
                    "THE HANGED MAN", "DEATH", "TEMPERANCE",
                    "THE DEVIL", "THE TOWER", "THE STAR",
                    "THE MOON", "THE SUN", "JUDGEMENT", "THE WORLD",

                     "THE FOOL REVERSED", "THE MAGICIAN REVERSED", "THE HIGH PRIESTESS REVERSED",
                     "THE EMPRESS REVERSED", "THE EMPEROR REVERSED", "THE HEIROPHANT REVERSED",
                    "THE LOVERS REVERSED", "THE CHARIOT REVERSED", "STRENGTH REVERSED",
                    "THE HERMIT REVERSED", "WHEEL OF FORTUNE REVERSED", "JUSTICE REVERSED",
                    "THE HANGED MAN REVERSED", "DEATH REVERSED ", "TEMPERANCE REVERSED",
                     "THE DEVIL REVERSED", "THE TOWER REVERSED", "THE STAR REVERSED",
                     "THE MOON REVERSED", "THE SUN REVERSED", "JUDGEMENT REVERSED", "THE WORLD REVERSED"

                 };

                List<string> shuffledDeck = new List<string>;

            }
            else
            {
                Console.WriteLine($"\t\t*****Ok love an light, see you next time!*****");
            }
        }
    }
}
