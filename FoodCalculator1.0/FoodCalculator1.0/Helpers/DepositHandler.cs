using FoodCalculator1._0.Models;
using FoodCalculator1._0.Services;
using FoodCalculator1._0.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodCalculator1._0.Helpers
{
    public class DepositHandler
    {
        
        DepositServices services;
    

        UtilitiesLocator uLocator;

        public DepositHandler()
        {
            uLocator = new UtilitiesLocator();
            services = new DepositServices();
        }

        public void AlterDeposits(int monthNumber, int usersChoice)
        {
            switch (usersChoice)
            {
                case 1:
                    int depositAmount = AddDeposit();
                    services.AddDeposit(monthNumber, depositAmount);
                    uLocator.style.PaintIfNumber($"{depositAmount}kr har nu satts in på månad {monthNumber}");
                    Console.WriteLine();
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case 2:

                    
                    break;

                case 3:
                    DeleteDeposit(monthNumber);
                    break;


                case 4:
                    PrintDeposits(monthNumber);
                    break;

                case 5:
                    break;

                case 6:
                    DeleteAllDeposits(monthNumber);
                    break;
            }
        }

        public void CreateMonth()
        {
            int monthNumber;
            services.validation.AskForAndParseToInt
            ("Ange månadsnummer :", out monthNumber);
            Month month = new Month(monthNumber, 0);
            services.AddMonth(month);
        }
        public int AddDeposit()
        {
            Console.WriteLine();
            int amountToDeposit;
            services.validation.AskForAndParseToInt
            ("Ange hur mycket du vill sätta in :", out amountToDeposit);
            return amountToDeposit;
        }
        public void DeleteDeposit(int monthNumber)
        {
            int amountToDelete;
            services.validation.AskForAndParseToInt
            ("Ange summan du vill ta bort :", out amountToDelete);
            services.DeleteDeposit(monthNumber, amountToDelete);
        }

        public void DeleteAllDeposits(int monthNumber)
        {
            Console.WriteLine();
            Console.WriteLine($"Är du säker på att du vill ta bort [ALLA] insättningar på månad {monthNumber}?");
            Console.WriteLine();
            Console.WriteLine("Yes [Y] / No [N]:");
            var answer = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (answer == 'Y' || answer == 'y')
            {
                services.DeleteAllDeposits(monthNumber);
            }
            Console.Clear();
        }

        public void PrintDeposits(int monthNumber)
        {
            int totalSum = 0;
            var listOfMonths = services.GetAll() as List<Month>;
            Console.WriteLine();
            foreach (var month in listOfMonths)
            {
                if (month.MonthNumber == monthNumber)
                {
                    if (month.Deposits.Count == 0)
                    {
                        uLocator.style.PaintIfNumber($"0kr");
                        Console.WriteLine();
                    }
                    foreach (var deposit in month.Deposits)
                    {
                        totalSum = totalSum + deposit;
                        uLocator.style.PaintIfNumber($"{deposit}kr");
                        Console.WriteLine("--------");
                    }
                    uLocator.style.PaintIfNumber($"Total månadskostnad: {totalSum}kr");
                }
            }
            Console.WriteLine();
            Console.Write("Tryck på valfri knapp för att gå tillbaka!");
            Console.ReadKey();
            Console.Clear();
        }
    }
}


























