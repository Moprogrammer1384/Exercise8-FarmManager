using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmManaging.Model.Classes;

namespace FarmManaging.Model.Interfaces
{
    public interface IProfitManager
    {
        public decimal DailyProfit(Animal Animal);

        public decimal LifeTimeProfit(Animal Animal);

        public decimal ProfitPredicting(Animal Animal, int Year);

        public List<(int, string, string, int, bool, decimal)> DailyProfit();

        public List<(int, string, string, int, bool, decimal)> LifeTimeProfit();

        public List<(int, string, string, int, bool, decimal)> ProfitPredicting(int Year);
    }
}
