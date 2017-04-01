using FoodCalculator1._0.Helpers;
using FoodCalculator1._0.Services;
using FoodCalculator1._0.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodCalculator1._0
{
    class Program
    {
        private DepositServices services;
        private Views.Views mainview;
        private ViewLocator viewlocator;
        private static bool RunProgram = true;
        public Program()
        {
            services = new DepositServices();
            mainview = new Views.Views();
            viewlocator = new ViewLocator();
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            while (RunProgram)
            {
                program.mainview.StartingView();

                int ValidatedInput = program.services.validation.ParsedInt();
                switch (ValidatedInput)
                {
                    case 1:

                        Console.Clear();
                        program.viewlocator.GetView();
                        break;
                    case 2:
                        RunProgram = false;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine(" [Fel Commando!]");
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}


