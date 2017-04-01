using System;

namespace FoodCalculator1._0.Views
{
    public class Views
    {
        public void StartingView()
        {
            Console.WriteLine(" FoodCalculator");
            Console.WriteLine();
            Console.WriteLine("[1] Insättningar");
            Console.WriteLine();
            Console.WriteLine("[2] Avsluta Programmet");
            Console.WriteLine();
        }
          
            

        public void MonthView()
        {
            Console.WriteLine("1: Januari");
            Console.WriteLine("2: Februari");
            Console.WriteLine("3: Mars");
            Console.WriteLine("4: April");
            Console.WriteLine("5: Maj");
            Console.WriteLine("6: Juni");
            Console.WriteLine("7: Juli");
            Console.WriteLine("8: Augusti");
            Console.WriteLine("9: September");
            Console.WriteLine("10: Oktober");
            Console.WriteLine("11: November");
            Console.WriteLine("12: December");
            Console.WriteLine();
            Console.Write("Välj månad mellan månad 1-12 :");
        }

        public void DepositView()
        {
            Console.WriteLine("[1] Lägg till en insättning ");
            Console.WriteLine();
            Console.WriteLine("[2] Ändra en insättning ");
            Console.WriteLine();
            Console.WriteLine("[3] Ta bort en insättning ");
            Console.WriteLine();
            Console.WriteLine("[4] Visa Månadssaldo");
            Console.WriteLine();
            Console.WriteLine("[5] Skapa en månad");
            Console.WriteLine();
            Console.WriteLine("[6] Ta bort [alla] insättningar på specifik månad");
            Console.WriteLine();
            Console.WriteLine("[7] Tillbaka");

        }
    }
}
           
            
