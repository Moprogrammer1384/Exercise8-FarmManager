using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmManaging.Model.Classes;

namespace FarmManaging.Model.Interfaces
{
    public interface IIncomeManager
    {
        public decimal DailyIncome(Animal Animal);

        public decimal MeatIncome(Animal Animal);

        public decimal CalvesIncome(Animal Animal);

        public decimal LifeTimeIncome(Animal Animal);

        public decimal IncomePredicting(Animal Animal, int Year);

        public List<(int, string, string, int, bool, decimal)> MeatIncome();

        public List<(int, string, string, int, bool, decimal)> CalvesIncome();
    }
}
