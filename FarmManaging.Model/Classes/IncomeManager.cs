using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmManaging.Model.Interfaces;

namespace FarmManaging.Model.Classes
{
    public  class IncomeManager : IIncomeManager
    {
        private List<double> DailyProduces;

        private readonly IAnimalRepository _animalRepository;

        public IncomeManager(IAnimalRepository animalRepository)
        {
            _animalRepository = animalRepository;
        }

        public decimal DailyIncome(Animal Animal)
        {
            decimal TotalIncome = 0;

            foreach (Product Product in Animal.Products.Where(p => p.Name != "Meat" && p.Name != "Calf"))
            {
                TotalIncome += Product.Price * (decimal)Product.DailyProduce;
            }

            return TotalIncome;
        }

        public decimal MeatIncome(Animal Animal)
        {
            decimal MeatProfit = 0;

            foreach (Product Product in Animal.Products.Where(p => p.Name == "Meat"))
            {
                MeatProfit += Product.Price * (decimal)Product.DailyProduce;
            }

            return MeatProfit;
        }

        public decimal CalvesIncome(Animal Animal)
        {
            decimal CalvesProfit = 0;

            foreach (Product Product in Animal.Products.Where(p => p.Name == "Calf"))
            {
                CalvesProfit += Product.Price * (decimal)Product.DailyProduce;
            }

            return CalvesProfit;
        }

        public List<(int, string, string, int, bool, decimal)> MeatIncome()
        {
            List<(int ID, string Name, string Gender, int Age, bool IsSick, decimal MeatProfit)> Data =
                new List<(int ID, string Name, string Gender, int Age, bool IsSick, decimal MeatProfit)>();

            (int ID, string Name, string Gender, int Age, bool IsSick, decimal MeatProfit) MeatProfits;

            foreach (Animal Animal in _animalRepository.GetAllAnimals())
            {
                MeatProfits = (Animal.ID, Animal.Name, Animal.Gender.ToString(), Animal.Age, Animal.IsSick, MeatIncome(Animal));

                Data.Add(MeatProfits);
            }

            return Data;
        }

        public List<(int, string, string, int, bool, decimal)> CalvesIncome()
        {
            List<(int ID, string Name, string Gender, int Age, bool IsSick, decimal CalvesProfit)> Data =
                new List<(int ID, string Name, string Gender, int Age, bool IsSick, decimal CalvesProfit)>();

            (int ID, string Name, string Gender, int Age, bool IsSick, decimal CalvesProfit) CalvesProfits;

            foreach (Animal Animal in _animalRepository.GetAllAnimals())
            {
                CalvesProfits = (Animal.ID, Animal.Name, Animal.Gender.ToString(), Animal.Age, Animal.IsSick, CalvesIncome(Animal));

                Data.Add(CalvesProfits);
            }

            return Data;
        }

        public decimal LifeTimeIncome(Animal Animal)
        {
            int RemainLife = Animal.MaxAge - Animal.Age;
            int Age = Animal.Age;
            decimal TotalIncome = 0;

            SetDailyProduces(Animal);
            if (Animal.IsSick)
                Animal.Products.ForEach(Product => Product.DailyProduce -= 0.4 * Product.DailyProduce);
            for (int i = 0; i < RemainLife; i++)
            {
                TotalIncome += (DailyIncome(Animal) * 365) + (CalvesIncome(Animal) * 12);
                switch (Animal.MaxAge - Age)
                {
                    case int difference when difference >= 4 && difference <= 6:
                        Animal.Products.ForEach(Product => Product.DailyProduce -= 0.2 * Product.DailyProduce);
                        break;
                    case int difference when difference >= 2 && difference < 4:
                        Animal.Products.ForEach(Product => Product.DailyProduce -= 0.3 * Product.DailyProduce);
                        break;
                    case int difference when difference < 2:
                        Animal.Products.ForEach(Product => Product.DailyProduce -= 0.5 * Product.DailyProduce);
                        break;
                }
                Age++;
            }
            TotalIncome += MeatIncome(Animal);
            ReturnDailyProduces(Animal);
            return TotalIncome;
        }

        public decimal IncomePredicting(Animal Animal, int Year)
        {
            int Age = Animal.Age;
            decimal TotalIncome = 0;

            SetDailyProduces(Animal);

            if (Animal.IsSick)
                Animal.Products.ForEach(Product => Product.DailyProduce -= 0.4 * Product.DailyProduce);

            for (int i = 0; i < Year; i++)
            {
                if (Age < Animal.MaxAge)
                {
                    TotalIncome += (DailyIncome(Animal) * 365) + (CalvesIncome(Animal) * 12);
                    switch (Animal.MaxAge - Age)
                    {
                        case int difference when difference >= 4 && difference <= 6:
                            Animal.Products.ForEach(Product => Product.DailyProduce -= 0.2 * Product.DailyProduce);
                            break;
                        case int difference when difference >= 2 && difference < 4:
                            Animal.Products.ForEach(Product => Product.DailyProduce -= 0.3 * Product.DailyProduce);
                            break;
                        case int difference when difference < 2:
                            Animal.Products.ForEach(Product => Product.DailyProduce -= 0.5 * Product.DailyProduce);
                            break;
                    }
                    Age++;
                }
                else
                    break;
            }
            TotalIncome += MeatIncome(Animal);
            ReturnDailyProduces(Animal);
            return TotalIncome;
        }

        private void SetDailyProduces(Animal Animal)
        {
            DailyProduces = new List<double>();
            foreach (Product Product in Animal.Products)
            {
                DailyProduces.Add(Product.DailyProduce);
            }
        }

        private void ReturnDailyProduces(Animal Animal)
        {
            int i = 0;
            foreach (Product Product in Animal.Products)
            {
                Product.DailyProduce = DailyProduces[i];
                i++;
            }
        }
    }
}
