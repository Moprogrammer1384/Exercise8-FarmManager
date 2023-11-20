using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmManaging.Model.Classes;

namespace FarmManaging.Model.Interfaces
{
    public interface ICostManager
    {
        public decimal DailyCost(Animal Animal);

        public decimal LifeTimeCost(Animal Animal);

        public decimal CostPredicting(Animal Animal, int Year);
    }
}
