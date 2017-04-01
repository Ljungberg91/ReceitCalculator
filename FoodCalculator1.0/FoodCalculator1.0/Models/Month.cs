using System.Collections.Generic;

namespace FoodCalculator1._0.Models
{
    public class Month
    {
        public int MonthNumber { get; set; }
        public int Deposit { get; set; }
        public List<int> Deposits { get; set; }
        public Month(int monthNumber, int deposit)
        {
            Deposits = new List<int>();
            MonthNumber = monthNumber;
            Deposit = deposit;
        }
        public Month(int deposit)
        {
            Deposit = deposit;
        }

        public Month()
        {

        }

    }
}
