using FoodCalculator1._0.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace FoodCalculator1._0.Repositories
{
    public class Repository
    {
        private static Repository _instance;
        private List<Month> DepositsCollection;
        
        private string xmlFile;
        
        public static Repository Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Repository();
                }
                return _instance;
            }
        }
        public Repository()
        {
            DepositsCollection = new List<Month>();
            var path = Directory.GetCurrentDirectory();
            xmlFile = Path.Combine(path, "MonthDeposits.xml");
            
            Load();
        }

        public IEnumerable GetAll()
        {
            return DepositsCollection;
        }

        public void AddMonth(Month month)
        {
            DepositsCollection.Add(month);
            Save();
        }
        public void DeleteMonth(int monthNumber)
        {
            Month month = DepositsCollection.Find(m => m.MonthNumber == monthNumber);
            try
            {
                DepositsCollection.Remove(month);
            }
            catch
            {
                Console.WriteLine("Kunde inte ta bort angiven månad!");
                Console.WriteLine("Are you sure you entered a valid monthnumber?");
            }
            Save();
        }

        public void AddDeposit(int monthNumber, int deposit)
        {
            try
            {
                Month month = DepositsCollection.Find(m => m.MonthNumber == monthNumber);
                month.Deposits.Add(deposit);
                Save();
            }
            catch
            {
                Console.WriteLine("Insättningen misslyckades!");
            }
        }



        public void DeleteAllDeposits(int monthNumber)
        {
            Month month = DepositsCollection.Find(m => m.MonthNumber == monthNumber);
            try
            {
                month.Deposits.RemoveRange(0, month.Deposits.Count);
                Console.WriteLine($"Alla insättningar för månad {monthNumber} har raderats! ");
                Console.ReadKey();
                Console.Clear();
                Save();
            }
            catch
            {
                Console.WriteLine("Någonting gick fel!");
            }
        }
        public void DeleteDeposit(int monthNumber, int deposit)
        {
            try
            {
                Month month = DepositsCollection.Find(m => m.MonthNumber == monthNumber);
                if (month.Deposit <= 0)
                    Console.WriteLine("Beloppet existerar inte, ingenting togs bort!");
                Console.ReadKey();
                Console.Clear();
                month.Deposits.Remove(deposit);
            }
            catch
            {
                Console.WriteLine("Kunde inte ta bort angivet belopp!");
                Console.WriteLine("Kontrollera att beloppet existerar och försök igen.");
            }
            Save();
        }

        private void Load()
        {
            using (Stream stream = File.Open(xmlFile, FileMode.OpenOrCreate))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Month>));
                DepositsCollection = (List<Month>)serializer.Deserialize(stream);
            }
        }

        private void Save()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Month>));
            using (Stream stream = File.Open(xmlFile, FileMode.Create))
            {
                serializer.Serialize(stream, DepositsCollection);
            }
        }
    }
}





