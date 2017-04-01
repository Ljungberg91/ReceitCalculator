using FoodCalculator1._0.Models;
using FoodCalculator1._0.Repositories;
using FoodCalculator1._0.ValueObjects;
using System.Collections;

namespace FoodCalculator1._0.Services
{
    public class DepositServices
    {
        Repository repository;
        public Validation validation;
        public DepositServices()
        {
            validation = new Validation();
            repository = Repository.Instance;
        }
        public IEnumerable GetAll()
        {
            return repository.GetAll();
        }
        public void AddMonth(Month month)
        {
            repository.AddMonth(month);
        }

        public void AddDeposit(int monthNumber, int deposit)
        {
            repository.AddDeposit(monthNumber, deposit);
        }

        public void DeleteAllDeposits(int monthNumber)
        {
            repository.DeleteAllDeposits(monthNumber);
        }
        public void DeleteDeposit(int monthNumber, int deposit)
        {
            repository.DeleteDeposit(monthNumber, deposit);
        }
    }
}
