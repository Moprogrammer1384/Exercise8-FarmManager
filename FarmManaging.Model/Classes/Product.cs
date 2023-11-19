using FarmManaging.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FarmManaging.Model.Classes
{
    public class Product : IProduct
    {
        public string Name { get; set; }

        public string UnitOfMeasure { get; set; }

        public decimal Price { get; set; }

        public double DailyProduce { get; set; }
    }
}
