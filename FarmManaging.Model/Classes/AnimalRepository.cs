using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmManaging.Model.Interfaces;
using FarmManaging.Model.Classes;


namespace FarmManaging.Model.Classes
{
    public class AnimalRepository : IAnimalRepository
    {
        private List<Animal> _animals = new List<Animal>();

        private List<double> DailyProduces;

        private List<double> DailyUsages;

        public List<Animal> GetAllAnimals()
        {
            if (CountCheck())
                return _animals;
            else
                throw new NullReferenceException();
        }

        public void AddAnimal(string Name,
                      string Type,
                      Gender Gender,
                      int Age,
                      int MaxAge,
                      bool IsSick,
                      List<Product> Products,
                      List<Cost> Costs)
        {
            Animal Animal = new Animal();
            Animal.ID = _animals.Count + 1;
            Animal.Name = Name;
            Animal.Type = Type;
            Animal.Gender = Gender;
            Animal.Age = Age;
            Animal.MaxAge = MaxAge;
            Animal.IsSick = IsSick;
            Animal.Products = Products;
            Animal.Costs = Costs;

            _animals.Add(Animal);
        }

        public void AddAnimal(Animal Animal)
        {
            Animal.ID = _animals.Count + 1;
            _animals.Add(Animal);
        }

        public void DeleteAnimal(int ID)
        {
            if (CountCheck())
            {
                Animal Animal = Search(ID);
                _animals.Remove(Animal);                
            }
        }

        public void EditAnimal(Animal Animal)
        {
            if (CountCheck())
            {
                DeleteAnimal(Animal.ID);
                AddAnimal(Animal);
            }
        }

        public Animal Search(int ID)
        {
            Animal Animal = _animals.FirstOrDefault(animal => animal.ID == ID);
            if (Animal != null)
            {
                return Animal;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public decimal DailyCost(Animal Animal)
        {
            decimal TotalCost = 0;

            foreach (Cost Cost in Animal.Costs)
            {
                TotalCost += Cost.Price * (decimal)Cost.DailyUsage;
            }

            return TotalCost;
        }

        public decimal DailyIncome(Animal Animal)
        {
            decimal TotalIncome = 0;

            foreach (Product Product in Animal.Products.Where(p => p.Name != "Meat"))
            {
                TotalIncome += Product.Price * (decimal)Product.DailyProduce;
            }

            return TotalIncome;
        }

        public decimal MeatProfit(Animal Animal)
        {
            decimal MeatProfit = 0;

            foreach (Product Product in Animal.Products.Where(p => p.Name == "Meat"))
            {
                MeatProfit += Product.Price * (decimal)Product.DailyProduce;
            }

            return MeatProfit;
        }

        public decimal DailyProfit(Animal Animal)
        {
            return (DailyIncome(Animal) + MeatProfit(Animal)) - DailyCost(Animal);
        }

        public List<(int, string, string, int, bool, decimal)> DailyProfit()
        {

            List<(int ID, string Name, string Gender, int Age, bool IsSick, decimal DailyProfit)> Data =
                new List<(int ID, string Name, string Gender, int Age, bool IsSick, decimal DailyProfit)>();

            (int ID, string Name, string Gender, int Age, bool IsSick, decimal DailyProfit) DailyProfits;

            foreach (Animal Animal in _animals)
            {
                DailyProfits = (Animal.ID, Animal.Name, Animal.Gender.ToString(), Animal.Age, Animal.IsSick, DailyProfit(Animal));

                Data.Add(DailyProfits);
            }

            return Data;
        }

        public List<(int, string, string, int, bool, decimal)> MeatProfit()
        {
            List<(int ID, string Name, string Gender, int Age, bool IsSick, decimal MeatProfit)> Data =
                new List<(int ID, string Name, string Gender, int Age, bool IsSick, decimal MeatProfit)>();

            (int ID, string Name, string Gender, int Age, bool IsSick, decimal MeatProfit) MeatProfits;

            foreach (Animal Animal in _animals)
            {
                MeatProfits = (Animal.ID, Animal.Name, Animal.Gender.ToString(), Animal.Age, Animal.IsSick, MeatProfit(Animal));

                Data.Add(MeatProfits);
            }

            return Data;
        }

        public decimal LifeTimeIncome(Animal Animal)
        {
            int RemainLife = Animal.MaxAge - Animal.Age;
            int Age = Animal.Age;
            decimal TotalIncome = 0;

            SetDailyProduces(Animal);  
            if(Animal.IsSick)
                Animal.Products.ForEach(Product => Product.DailyProduce -= 0.4 * Product.DailyProduce);
            for (int i = 0; i < RemainLife; i++)
            {
                TotalIncome += (DailyIncome(Animal) * 365);
                switch(Animal.MaxAge - Age)
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
            TotalIncome += MeatProfit(Animal);            
            ReturnDailyProduces(Animal);
            return TotalIncome;           
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

        public decimal LifeTimeProfit(Animal Animal)
        {
            return LifeTimeIncome(Animal) - LifeTimeCost(Animal); 
        }

        public List<(int, string, string, int, bool, decimal)> LifeTimeProfit()
        {
            List<(int ID, string Name, string Gender, int Age, bool IsSick, decimal LifeTimeProfit)> Data =
                new List<(int ID, string Name, string Gender, int Age, bool IsSick, decimal LifeTimeProfit)>();

            (int ID, string Name, string Gender, int Age, bool IsSick, decimal LifeTimeProfit) LifeTimeProfitData;

            foreach (Animal Animal in _animals)
            {
                LifeTimeProfitData = (Animal.ID, Animal.Name, Animal.Gender.ToString(), Animal.Age, Animal.IsSick, LifeTimeProfit(Animal));

                Data.Add(LifeTimeProfitData);
            }

            return Data;
        }

        public decimal IncomePredicting(Animal Animal, int Year)
        {
            int Age = Animal.Age;
            decimal TotalIncome = 0;

            SetDailyProduces(Animal);

            if(Animal.IsSick)
                Animal.Products.ForEach(Product => Product.DailyProduce -= 0.4 * Product.DailyProduce);

            for (int i = 0; i < Year; i++)
            {
                if (Age < Animal.MaxAge)
                {
                    TotalIncome += (DailyIncome(Animal) * 365);
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
            TotalIncome += MeatProfit(Animal);
            ReturnDailyProduces(Animal);
            return TotalIncome;
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

        public decimal ProfitPredicting(Animal Animal, int Year)
        {
            return IncomePredicting(Animal, Year) - CostPredicting(Animal, Year);

        }

        public List<(int, string, string, int, bool, decimal)> ProfitPredicting(int Year)
        {
            List<(int ID, string Name, string Gender, int Age, bool IsSick, decimal PredictedProfit)> Data =
                new List<(int ID, string Name, string Gender, int Age, bool IsSick, decimal PredictedProfit)>();

            (int ID, string Name, string Gender, int Age, bool IsSick, decimal PredictedProfit) PredictedProfit;

            foreach (Animal Animal in _animals)
            {
                PredictedProfit = (Animal.ID, 
                                Animal.Name, 
                                Animal.Gender.ToString(), 
                                Animal.Age, 
                                Animal.IsSick, 
                                ProfitPredicting(Animal, Year));
                Data.Add(PredictedProfit);
            }

            return Data;
        }

        private bool CountCheck()
        {
            if (_animals.Count > 0)
                return true;
            else
                return false;
        }

        private void SetDailyProduces(Animal Animal)
        {
            DailyProduces = new List<double>();
            foreach (Product Product in Animal.Products)
            {
                DailyProduces.Add(Product.DailyProduce);
            }
        }

        private void SetDailyUsages(Animal Animal)
        {
            DailyUsages = new List<double>();
            foreach (Cost Cost in Animal.Costs)
            {
                DailyUsages.Add(Cost.DailyUsage);
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
