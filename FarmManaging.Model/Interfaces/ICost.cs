using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmManaging.Model.Interfaces
{
    public interface ICost
    {
        public string Name { get; set; }

        public string UnitOfMeasure { get; set; }

        public decimal Price { get; set; }

        public double DailyUsage { get; set; }
    }
}
