using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmManaging.Model.Classes;
using FarmManaging.Model.Interfaces;

namespace FarmManaging.Model.Classes
{
    public class Animal : IAnimal
    {        
        public int ID { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public Gender Gender { get; set; }

        public int Age { get; set; }

        public int MaxAge { get; set; }

        public bool IsSick { get; set; }

        public List<Product> Products { get; set; }

        public List<Cost> Costs { get; set; }
    }
}
