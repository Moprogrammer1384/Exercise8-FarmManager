using FarmManaging.Model.Classes;
using FarmManaging.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmManaging.Model.Interfaces
{
    public interface IAnimalRepository
    {
        public List<Animal> GetAllAnimals();

        public void AddAnimal( string Name,
                      string Type,
                      Gender Gender,
                      int Age,
                      int MaxAge,
                      bool IsSick,
                      List<Product> Products,
                      List<Cost> Costs);

        public void AddAnimal(Animal Animal);

        public void DeleteAnimal(int ID);

        public void EditAnimal(Animal Animal);

        public Animal Search(int ID);

        public decimal DailyIncome(Animal Animal);

        public decimal DailyCost(Animal Animal);

        public decimal DailyProfit(Animal Animal);

        public decimal MeatProfit(Animal Animal);

        public List<(int, string, string, int, bool, decimal)> DailyProfit();

        public List<(int, string, string, int, bool, decimal)> MeatProfit();

        public decimal LifeTimeIncome(Animal Animal);

        public decimal LifeTimeCost(Animal Animal);

        public decimal LifeTimeProfit(Animal Animal);

        public List<(int, string, string, int, bool, decimal)> LifeTimeProfit();

        public decimal IncomePredicting(Animal Animal, int Year);

        public decimal CostPredicting(Animal Animal, int Year);

        public decimal ProfitPredicting(Animal Animal, int Year);

        public List<(int, string, string, int, bool, decimal)> ProfitPredicting(int Year);

    }
}
