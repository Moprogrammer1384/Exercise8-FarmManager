using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmManaging.Model.Interfaces;
    
namespace FarmManaging.Model.Classes
{
    public class ProfitManager : IProfitManager
    {
        private IncomeManager _incomeManager;

        private CostManager _costManager;

        private AnimalRepository _animalRepository;

        public ProfitManager(AnimalRepository animalRepository, IncomeManager incomeManager, CostManager costManager)
        {
            _animalRepository = animalRepository;
            _incomeManager = incomeManager;
            _costManager = costManager;
        }

        public decimal DailyProfit(Animal Animal)
        {
            return _incomeManager.DailyIncome(Animal) - _costManager.DailyCost(Animal);
        }

        public List<(int, string, string, int, bool, decimal)> DailyProfit()
        {

            List<(int ID, string Name, string Gender, int Age, bool IsSick, decimal DailyProfit)> Data =
                new List<(int ID, string Name, string Gender, int Age, bool IsSick, decimal DailyProfit)>();

            (int ID, string Name, string Gender, int Age, bool IsSick, decimal DailyProfit) DailyProfits;

            foreach (Animal Animal in _animalRepository.GetAllAnimals())
            {
                DailyProfits = (Animal.ID, Animal.Name, Animal.Gender.ToString(), Animal.Age, Animal.IsSick, DailyProfit(Animal));

                Data.Add(DailyProfits);
            }

            return Data;
        }

        public decimal LifeTimeProfit(Animal Animal)
        {
            return _incomeManager.LifeTimeIncome(Animal) - _costManager.LifeTimeCost(Animal);
        }

        public List<(int, string, string, int, bool, decimal)> LifeTimeProfit()
        {
            List<(int ID, string Name, string Gender, int Age, bool IsSick, decimal LifeTimeProfit)> Data =
                new List<(int ID, string Name, string Gender, int Age, bool IsSick, decimal LifeTimeProfit)>();

            (int ID, string Name, string Gender, int Age, bool IsSick, decimal LifeTimeProfit) LifeTimeProfitData;

            foreach (Animal Animal in _animalRepository.GetAllAnimals())
            {
                LifeTimeProfitData = (Animal.ID, Animal.Name, Animal.Gender.ToString(), Animal.Age, Animal.IsSick, LifeTimeProfit(Animal));

                Data.Add(LifeTimeProfitData);
            }

            return Data;
        }

        public decimal ProfitPredicting(Animal Animal, int Year)
        {
            return _incomeManager.IncomePredicting(Animal, Year) - _costManager.CostPredicting(Animal, Year);
        }

        public List<(int, string, string, int, bool, decimal)> ProfitPredicting(int Year)
        {
            List<(int ID, string Name, string Gender, int Age, bool IsSick, decimal PredictedProfit)> Data =
                new List<(int ID, string Name, string Gender, int Age, bool IsSick, decimal PredictedProfit)>();

            (int ID, string Name, string Gender, int Age, bool IsSick, decimal PredictedProfit) PredictedProfit;

            foreach (Animal Animal in _animalRepository.GetAllAnimals())
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
    }
}
