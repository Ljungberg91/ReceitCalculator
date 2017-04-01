using FoodCalculator1._0.Services;
using System;

namespace FoodCalculator1._0.ValueObjects
{
    public class Validation
    {
        UtilitiesLocator uLocator;
        public Validation()
        {
            uLocator = new UtilitiesLocator();
        }
        public void AskForAndParseToInt(string askingPhrase, out int result)
        {
            Console.Write(askingPhrase);
            var userInput = Console.ReadLine();

            while (!int.TryParse(userInput, out result))
            {
                uLocator.style.PaintStrings("Måste vara en siffra! Försök igen :", true, false);
                userInput = Console.ReadLine();
                Console.WriteLine();
            }
            Console.Clear();
        }

                
        public int ParsedInt()
        {
            var userInput = Console.ReadLine();
            int result;
            while (!int.TryParse(userInput, out result))
            {
                uLocator.style.PaintStrings("Måste vara en siffra! Försök igen :", true, false);
                userInput = Console.ReadLine();
                Console.WriteLine();
            }
            return result;
        }
    }
}
