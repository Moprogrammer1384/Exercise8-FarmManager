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
      
        private bool CountCheck()
        {
            if (_animals.Count > 0)
                return true;
            else
                return false;
        }
        
    }
}
