using FarmManaging.Model.Classes;
using FarmManaging.Model.Interfaces;
using System.Globalization;

AnimalRepository AnimalRepository = new AnimalRepository();

AnimalRepository.AddAnimal("Cow", "Domestic", Gender.Male, 8, 10, true, 
                           new List<Product>()
                           {
                               new Product()
                               {
                                   Name = "Calf",
                                   UnitOfMeasure = "Kg",
                                   Price = 300000,
                                   DailyProduce = 140
                               },
                               new Product()
                               {
                                   Name = "Meat",
                                   UnitOfMeasure = "Kg",
                                   Price = 300000,
                                   DailyProduce = 400
                               }
                           },
                           new List<Cost>()
                           {
                               new Cost()
                               {
                                   Name = "Grass",
                                   UnitOfMeasure = "Kg",
                                   Price = 10000,
                                   DailyUsage = 3
                               },
                               new Cost()
                               {
                                   Name = "Worker",
                                   UnitOfMeasure = "People",
                                   Price = 100000,
                                   DailyUsage = 2
                               }
                           });
AnimalRepository.AddAnimal("Cow", "Domestic", Gender.Female, 2, 10, false,
                           new List<Product>()
                           {
                               new Product()
                               {
                                   Name = "Meat",
                                   UnitOfMeasure = "Kg",
                                   Price = 250000,
                                   DailyProduce = 250
                               },
                               new Product()
                               {
                                   Name = "Milk",
                                   UnitOfMeasure = "Liter",
                                   Price = 20000,
                                    DailyProduce = 20
                               },
                               new Product()
                               {
                                   Name = "Cheese",
                                   UnitOfMeasure = "Kg",
                                   Price = 400000,
                                    DailyProduce = 3
                               },
                           },
                           new List<Cost>()
                           {
                               new Cost()
                               {
                                   Name = "Grass",
                                   UnitOfMeasure = "Kg",
                                   Price = 10000,
                                   DailyUsage = 3
                               },
                               new Cost()
                               {
                                   Name = "Worker",
                                   UnitOfMeasure = "People",
                                   Price = 100000,
                                   DailyUsage = 2
                               }
                           });
AnimalRepository.AddAnimal("Cow", "Domestic", Gender.Female, 4, 15, false,
                           new List<Product>()
                           {
                               new Product()
                               {
                                   Name = "Meat",
                                   UnitOfMeasure = "Kg",
                                   Price = 250000,
                                   DailyProduce = 200
                               },
                               new Product()
                               {
                                   Name = "Milk",
                                   UnitOfMeasure = "Liter",
                                   Price = 20000,
                                    DailyProduce = 20
                               },
                               new Product()
                               {
                                   Name = "Cheese",
                                   UnitOfMeasure = "Kg",
                                   Price = 400000,
                                    DailyProduce = 3
                               },
                           },
                           new List<Cost>()
                           {
                               new Cost()
                               {
                                   Name = "Grass",
                                   UnitOfMeasure = "Kg",
                                   Price = 10000,
                                   DailyUsage = 3
                               },
                               new Cost()
                               {
                                   Name = "Worker",
                                   UnitOfMeasure = "People",
                                   Price = 100000,
                                   DailyUsage = 2
                               }
                           });
AnimalRepository.AddAnimal("Cow", "Domestic", Gender.Male, 6, 10, true,
                           new List<Product>()
                           {
                               new Product()
                               {
                                   Name = "Calf",
                                   UnitOfMeasure = "Kg",
                                   Price = 300000,
                                   DailyProduce = 210
                               },
                               new Product()
                               {
                                   Name = "Meat",
                                   UnitOfMeasure = "Kg",
                                   Price = 300000,
                                   DailyProduce = 500
                               }
                           },
                           new List<Cost>()
                           {
                               new Cost()
                               {
                                   Name = "Grass",
                                   UnitOfMeasure = "Kg",
                                   Price = 10000,
                                   DailyUsage = 3
                               },
                               new Cost()
                               {
                                   Name = "Worker",
                                   UnitOfMeasure = "People",
                                   Price = 100000,
                                   DailyUsage = 2
                               }
                           });
AnimalRepository.AddAnimal("Cow", "Domestic", Gender.Female, 1, 12, false,
                           new List<Product>()
                           {
                               new Product()
                               {
                                   Name = "Meat",
                                   UnitOfMeasure = "Kg",
                                   Price = 200000,
                                   DailyProduce = 250
                               },
                               new Product()
                               {
                                   Name = "Milk",
                                   UnitOfMeasure = "Liter",
                                   Price = 20000,
                                    DailyProduce = 20
                               },
                               new Product()
                               {
                                   Name = "Cheese",
                                   UnitOfMeasure = "Kg",
                                   Price = 400000,
                                    DailyProduce = 3
                               },
                           },
                           new List<Cost>()
                           {
                               new Cost()
                               {
                                   Name = "Grass",
                                   UnitOfMeasure = "Kg",
                                   Price = 10000,
                                   DailyUsage = 3
                               },
                               new Cost()
                               {
                                   Name = "Worker",
                                   UnitOfMeasure = "People",
                                   Price = 100000,
                                   DailyUsage = 2
                               }
                           });
AnimalRepository.AddAnimal("Cow", "Domestic", Gender.Male, 5, 11, false,
                           new List<Product>()
                           {
                               new Product()
                               {
                                   Name = "Calf",
                                   UnitOfMeasure = "Kg",
                                   Price = 300000,
                                   DailyProduce = 140
                               },
                               new Product()
                               {
                                   Name = "Meat",
                                   UnitOfMeasure = "Kg",
                                   Price = 300000,
                                   DailyProduce = 450
                               }
                           },
                           new List<Cost>()
                           {
                               new Cost()
                               {
                                   Name = "Grass",
                                   UnitOfMeasure = "Kg",
                                   Price = 10000,
                                   DailyUsage = 3
                               },
                               new Cost()
                               {
                                   Name = "Worker",
                                   UnitOfMeasure = "People",
                                   Price = 100000,
                                   DailyUsage = 2
                               }
                           });
AnimalRepository.AddAnimal("Cow", "Domestic", Gender.Female, 3, 10, false,
                           new List<Product>()
                           {
                               new Product()
                               {
                                   Name = "Meat",
                                   UnitOfMeasure = "Kg",
                                   Price = 250000,
                                   DailyProduce = 300
                               },
                               new Product()
                               {
                                   Name = "Milk",
                                   UnitOfMeasure = "Liter",
                                   Price = 20000,
                                    DailyProduce = 20
                               },
                               new Product()
                               {
                                   Name = "Cheese",
                                   UnitOfMeasure = "Kg",
                                   Price = 400000,
                                    DailyProduce = 3
                               },
                               new Product()
                               {
                                   Name = "Butter",
                                   UnitOfMeasure = "gr",
                                   Price = 81000,
                                   DailyProduce = 800
                               }
                           },
                           new List<Cost>()
                           {
                               new Cost()
                               {
                                   Name = "Grass",
                                   UnitOfMeasure = "Kg",
                                   Price = 10000,
                                   DailyUsage = 3
                               },
                               new Cost()
                               {
                                   Name = "Worker",
                                   UnitOfMeasure = "People",
                                   Price = 100000,
                                   DailyUsage = 3
                               }
                           });
AnimalRepository.AddAnimal("Cow", "Domestic", Gender.Female, 3, 10, false,
                           new List<Product>()
                           {
                               new Product()
                               {
                                   Name = "Meat",
                                   UnitOfMeasure = "Kg",
                                   Price = 250000,
                                   DailyProduce = 150
                               },
                               new Product()
                               {
                                   Name = "Milk",
                                   UnitOfMeasure = "Liter",
                                   Price = 20000,
                                    DailyProduce = 20
                               },
                               new Product()
                               {
                                   Name = "Cheese",
                                   UnitOfMeasure = "Kg",
                                   Price = 400000,
                                    DailyProduce = 3
                               },
                               new Product()
                               {
                                   Name = "Butter",
                                   UnitOfMeasure = "gr",
                                   Price = 81000,
                                   DailyProduce = 800
                               }
                           },
                           new List<Cost>()
                           {
                               new Cost()
                               {
                                   Name = "Grass",
                                   UnitOfMeasure = "Kg",
                                   Price = 10000,
                                   DailyUsage = 3
                               },
                               new Cost()
                               {
                                   Name = "Worker",
                                   UnitOfMeasure = "People",
                                   Price = 100000,
                                   DailyUsage = 3
                               }
                           });
AnimalRepository.AddAnimal("Cow", "Domestic", Gender.Female, 3, 10, false,
                           new List<Product>()
                           {
                               new Product()
                               {
                                   Name = "Meat",
                                   UnitOfMeasure = "Kg",
                                   Price = 250000,
                                   DailyProduce = 200
                               },
                               new Product()
                               {
                                   Name = "Milk",
                                   UnitOfMeasure = "Liter",
                                   Price = 20000,
                                    DailyProduce = 20
                               },
                               new Product()
                               {
                                   Name = "Cheese",
                                   UnitOfMeasure = "Kg",
                                   Price = 400000,
                                    DailyProduce = 3
                               },
                               new Product()
                               {
                                   Name = "Butter",
                                   UnitOfMeasure = "gr",
                                   Price = 81000,
                                   DailyProduce = 800
                               }
                           },
                           new List<Cost>()
                           {
                               new Cost()
                               {
                                   Name = "Grass",
                                   UnitOfMeasure = "Kg",
                                   Price = 10000,
                                   DailyUsage = 3
                               },
                               new Cost()
                               {
                                   Name = "Worker",
                                   UnitOfMeasure = "People",
                                   Price = 100000,
                                   DailyUsage = 3
                               }
                           });
AnimalRepository.AddAnimal("Cow", "Domestic", Gender.Male, 5, 11, false,
                           new List<Product>()
                           {
                               new Product()
                               {
                                   Name = "Calf",
                                   UnitOfMeasure = "Kg",
                                   Price = 300000,
                                   DailyProduce = 210
                               },
                               new Product()
                               {
                                   Name = "Meat",
                                   UnitOfMeasure = "Kg",
                                   Price = 300000,
                                   DailyProduce = 500
                               }
                           },
                           new List<Cost>()
                           {
                               new Cost()
                               {
                                   Name = "Grass",
                                   UnitOfMeasure = "Kg",
                                   Price = 10000,
                                   DailyUsage = 3
                               },
                               new Cost()
                               {
                                   Name = "Worker",
                                   UnitOfMeasure = "People",
                                   Price = 100000,
                                   DailyUsage = 2
                               }
                           });

void Welcome()
{
    string menu = @"
1. Show daily profit of animals.
2. Show meat profit of animals.
3. Show calves profit of animals.
4. Show life time profit of animals.
5. Predit and show farm's profit in future  
";
    Console.WriteLine("************************************");
    Console.WriteLine(menu);
    Console.WriteLine("************************************");
}

void SelectOption()
{
    do
    {
        Welcome();
        Console.Write("Please choose one of the options: ");
        List<(int ID, string Name, string Gender, int Age, bool IsSick, decimal Profit)> Datas;
        switch (Console.ReadLine())
        {
            case "1":
                Datas = AnimalRepository.DailyProfit();
                Print(Datas, "Daily Profit");
                break;
            case "2":
                Datas = AnimalRepository.MeatProfit();
                Print(Datas, "Meat Profit");
                break;
            case "3":
                Datas = AnimalRepository.CalvesProfit();
                Print(Datas, "Calves Profit");
                break;
            case "4":
                Datas = AnimalRepository.LifeTimeProfit();
                Print(Datas, "Life Time Profit");
                break;
            case "5":
                Console.Write("Please enter a year: ");
                string Input = Console.ReadLine();
                int Year = 0;
                if (IsInt(Input))
                    Year = Convert.ToInt32(Input);
                else
                    Console.WriteLine("Please enter a correct number!!!");
                Datas = AnimalRepository.ProfitPredicting(Year);
                Print(Datas, "Predicted Profit");
                break;
            default:
                Console.WriteLine("!!Please enter a correct number!!");
                break;
        }
        
    }while(true);
}


void Print(List<(int ID, string Name, string Gender, int Age, bool IsSick, decimal Profit)> Datas, string ProfitType)
{
    decimal FarmTotalProfit = 0;

    foreach (var data in Datas)
    {
        FarmTotalProfit += data.Profit;
        Console.WriteLine($"ID: {data.ID}");
        Console.WriteLine($"Name: {data.Name}");
        Console.WriteLine($"Gender: {data.Gender}");
        Console.WriteLine($"Age: {data.Age}");
        Console.WriteLine($"IsSick: {data.IsSick}");
        Console.WriteLine($"{ProfitType}: {string.Format(CultureInfo.InvariantCulture, "{0:#,#.##}", data.Profit)}");
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("---------------------------------------------------");
    }
    Console.WriteLine($"Total Profit: {string.Format(CultureInfo.InvariantCulture, "{0:#,#.##}", FarmTotalProfit)}");
}

bool IsInt(string input)
{
    foreach (char c in input)
    {
        if (!Char.IsDigit(c))
        {
            return false;
        }
    }
    return true;
}

SelectOption();