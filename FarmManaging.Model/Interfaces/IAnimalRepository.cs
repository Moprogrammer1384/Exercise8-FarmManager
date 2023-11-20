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
        
    }
}
