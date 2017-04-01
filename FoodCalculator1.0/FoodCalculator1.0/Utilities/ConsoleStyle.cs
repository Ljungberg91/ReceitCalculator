using System;

namespace FoodCalculator1._0.Utilities
{
    public class ConsolePainting
    {
        public void PaintStrings(string message, bool isErrorMsg, bool isMsg)
        {
            if (isErrorMsg)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write(message);
            }
            Console.ResetColor();
        }
        public void PaintIfNumber(string input)
        {
            foreach (char character in input)
            {
                if (char.IsNumber(character))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(character);
                }
                else
                {
                    Console.Write(character);
                    Console.ResetColor();
                }
            }
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}











