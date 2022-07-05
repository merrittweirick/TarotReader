using System;
using System.Collections.Generic;
using System.Text;

namespace TarotReader_SideProject
{
    public class UserInterface
    {
        CardSpreads reading = new CardSpreads();
        public void Intro()
        {
            Console.WriteLine($"~~~Hello and Welcome!~~~");
            Console.ReadLine();
            
        }
        public void MainMenu()
        {
            Console.WriteLine("Would you like a reading today? (yes/no)");
            string readingAnswer = Console.ReadLine().ToLower();

            if(readingAnswer == "yes")
            {
                Console.Clear();
                Console.WriteLine("Wonderful! Let's start you out with a Three Card Spread.");
                Console.ReadLine();

                

                Console.WriteLine("Take a deep breath and focus on the question you would like answered...");
                Console.WriteLine("When you feel focused and grounded- hit enter to shuffle the deck.");
                Console.ReadLine();
                Console.Clear();
               
                reading.ShuffleDeck();
                
                Console.WriteLine("~~~~~Shuffling Deck~~~~~~~~");
                Console.WriteLine("When you intuitively feel the cards have found their rightful order, press enter to stop the shuffle." );
                Console.ReadLine();
                Console.Clear();
                //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Reading Method >>>>>>>>>>>>>>>>>>>>>>>>>>>>.

                Console.WriteLine("Insert Explanation of What Three Spread is/each card to be pulled Here");

                List<string> threeCardSpread = reading.ThreeCardSpread()

            }
        }

    }
}
