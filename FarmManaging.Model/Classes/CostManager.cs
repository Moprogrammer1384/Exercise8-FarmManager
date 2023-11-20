using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmManaging.Model.Interfaces;

namespace FarmManaging.Model.Classes
{
    public class CostManager : ICostManager
    {
        private List<double> DailyUsages;

        public decimal DailyCost(Animal Animal)
        {
            decimal TotalCost = 0;

            foreach (Cost Cost in Animal.Costs)
            {
                TotalCost += Cost.Price * (decimal)Cost.DailyUsage;
            }

            return TotalCost;
        }

        public decimal LifeTimeCost(Animal Animal)
        {
            int RemainLife = Animal.MaxAge - Animal.Age;
            int Age = Animal.Age;
            decimal TotalCost = 0;

            SetDailyUsages(Animal);
            for (int i = 0; i < RemainLife; i++)
            {
                TotalCost += DailyCost(Animal) * 365;
                switch (Animal.MaxAge - Age)
                {
                    case int difference when difference >= 4 && difference <= 6:
                        Animal.Costs.ForEach(Product => Product.DailyUsage += 0.1 * Product.DailyUsage);
                        break;
                    case int difference when difference >= 2 && difference < 4:
                        Animal.Costs.ForEach(Product => Product.DailyUsage += 0.2 * Product.DailyUsage);
                        break;
                    case int difference when difference < 2:
                        Animal.Costs.ForEach(Product => Product.DailyUsage += 0.3 * Product.DailyUsage);
                        break;
                }
                Age++;
            }
            ReturnDailyUsages(Animal);

            return TotalCost;
        }

        public decimal CostPredicting(Animal Animal, int Year)
        {
            int Age = Animal.Age;
            decimal TotalCost = 0;
            SetDailyUsages(Animal);
            for (int i = 0; i < Year; i++)
            {
                if (Age < Animal.MaxAge)
                {
                    TotalCost += DailyCost(Animal) * 365;
                    switch (Animal.MaxAge - Age)
                    {
                        case int difference when difference >= 4 && difference <= 6:
                            Animal.Costs.ForEach(Product => Product.DailyUsage += 0.1 * Product.DailyUsage);
                            break;
                        case int difference when difference >= 2 && difference < 4:
                            Animal.Costs.ForEach(Product => Product.DailyUsage += 0.2 * Product.DailyUsage);
                            break;
                        case int difference when difference < 2:
                            Animal.Costs.ForEach(Product => Product.DailyUsage += 0.3 * Product.DailyUsage);
                            break;
                    }
                    Age++;
                }
                else
                    break;
            }
            ReturnDailyUsages(Animal);
            return TotalCost;
        }

        private void SetDailyUsages(Animal Animal)
        {
            DailyUsages = new List<double>();
            foreach (Cost Cost in Animal.Costs)
            {
                DailyUsages.Add(Cost.DailyUsage);
            }
        }

        private void ReturnDailyUsages(Animal Animal)
        {
            int i = 0;
            foreach (Cost Cost in Animal.Costs)
            {
                Cost.DailyUsage = DailyUsages[i];
                i++;
            }
        }
    }
}
