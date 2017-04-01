using FoodCalculator1._0.Services;
using System;

namespace FoodCalculator1._0.Helpers
{
    public class ViewLocator
    {
        private DepositHandler depositHandler;
        DepositServices services;
        Views.Views mainView;
        private bool IsRunning = true;
        public ViewLocator()
        {
            mainView = new Views.Views();
            depositHandler = new DepositHandler();
            services = new DepositServices();
        }
        public void GetView()
        {
            IsRunning = true;
            while (IsRunning)
            {
                mainView.DepositView();
                Console.WriteLine();
                int ValidatedInput = services.validation.ParsedInt();
                switch (ValidatedInput)
                {
                    case 1:
                        Console.Clear();
                        mainView.MonthView();
                        ValidatedInput = services.validation.ParsedInt();
                        depositHandler.AlterDeposits(ValidatedInput, 1);
                        break;

                    case 2:
                        Console.Clear();
                        mainView.MonthView();
                        ValidatedInput = services.validation.ParsedInt();
                        depositHandler.AlterDeposits(ValidatedInput, 2);
                        break;

                    case 3:
                        Console.Clear();
                        mainView.MonthView();
                        ValidatedInput = services.validation.ParsedInt();
                        depositHandler.AlterDeposits(ValidatedInput, 3);
                        break;

                    case 4:
                        Console.Clear();
                        Console.Write("Ange vilken månad 1-12 :");
                        ValidatedInput = services.validation.ParsedInt();
                        depositHandler.AlterDeposits(ValidatedInput, 4);
                        break;

                    case 5:
                        Console.Clear();
                        depositHandler.CreateMonth();
                        break;

                    case 6:
                        Console.Clear();
                        Console.Write("Ange vilken månad 1-12 :");
                        ValidatedInput = services.validation.ParsedInt();
                        depositHandler.AlterDeposits(ValidatedInput,6);
                        break;

                    case 7:
                        Console.Clear();
                        IsRunning = false;
                        break;

                    default:
                        Console.Clear();
                        break;
                }
            }
        }
    }
}












