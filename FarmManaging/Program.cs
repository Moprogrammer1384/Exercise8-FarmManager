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
                                   DailyProduce = 2
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
                                   DailyProduce = 1
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
3. Show life time profit of animals.
4. Predit and show farm's profit in future  
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
        List<(int ID, string Name, string Gender, int Age, bool IsSick, decimal DailyProfit)> Datas;
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
                Datas = AnimalRepository.LifeTimeProfit();
                Print(Datas, "Life Time Profit");
                break;
            case "4":
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
//void Add()
//{
//    Console.Write("How many animals do you want to add??");
//    string Input = Console.ReadLine();
//    int Number = 0;
//    Animal Animal;
//    if (IsInt(Input))
//    {
//        Number = Convert.ToInt32(Input);
//    }
//    else
//    {
//        Console.WriteLine("!!Please enter a correct number!!");
//    }

//    for (int i = 1; i <= Number; i++)
//    {
//        Console.WriteLine($"***Animal number {i}***");
//        Animal = new Animal(); 
//        Console.Write("Name: ");
//        Animal.Name = Console.ReadLine().Trim();
//        Console.Write("Type: ");
//        Animal.Type = Console.ReadLine().Trim();
//        Console.Write("Gender: ");
//        Animal.Gender = (Gender)Enum.Parse(typeof(Gender),Console.ReadLine().Trim());
//        Console.Write("Age: ");
//        string AgeInput = Console.ReadLine();
//        if (IsInt(AgeInput))
//        {
//            Animal.Age = Convert.ToInt32(AgeInput);
//        }
//        Console.Write("Max Age: ");
//        string MaxAgeInput = Console.ReadLine();
//        int MaxAge = 0;
//        if (IsInt(MaxAgeInput))
//        {
//            Animal.MaxAge = Convert.ToInt32(MaxAgeInput);
//        }
//        Console.Write("IsSick: ");
//        if (Console.ReadLine() == "true")
//            Animal.IsSick = true;
//        else
//            Animal.IsSick = false;
//        Console.Write("How many products does it have? ");
//        string ProductInput = Console.ReadLine();
//        int ProductNumber = 0;
//        if (IsInt(ProductInput))
//        {
//            ProductNumber = Convert.ToInt32(ProductInput);
//        }
//        else
//        {
//            Console.WriteLine("!!Please enter a correct number!!");
//        }
//        List<Product> Products = new List<Product>();
//        for (int j = 0; j < ProductNumber; j++)
//        {
//            Product Product = new Product();
//            Console.Write("Name: ");
//            Product.Name = Console.ReadLine().Trim();
//            Console.Write("UnitOfMeasure: ");
//            Product.UnitOfMeasure = Console.ReadLine().Trim();
//            Console.Write("Price: ");
//            Product.Price = Convert.ToDecimal(Console.ReadLine());
//            Console.Write("DailyProduce: ");
//            Product.DailyProduce = Convert.ToDouble(Console.ReadLine());
//            Products.Add(Product);
//        }
//        Animal.Products = Products;
//        Console.Write("How many costs does it have? ");
//        string CostInput = Console.ReadLine();
//        int CostNumber = 0;
//        if (IsInt(CostInput))
//        {
//            CostNumber = Convert.ToInt32(CostInput);
//        }
//        else
//        {
//            Console.WriteLine("!!Please enter a correct number!!");
//        }
//        List<Cost> Costs = new List<Cost>();
//        for (int j = 0; j < ProductNumber; j++)
//        {
//            Cost Cost = new Cost();
//            Console.Write("Name: ");
//            Cost.Name = Console.ReadLine().Trim();
//            Console.Write("UnitOfMeasure: ");
//            Cost.UnitOfMeasure = Console.ReadLine().Trim();
//            Console.Write("Price: ");
//            Cost.Price = Convert.ToDecimal(Console.ReadLine());
//            Console.Write("DailyUsage: ");
//            Cost.DailyUsage = Convert.ToDouble(Console.ReadLine());
//            Costs.Add(Cost);
//        }
//        Animal.Costs = Costs;
//        AnimalRepository.AddAnimal(Animal);
//        Console.WriteLine("****************************************");
//    }
//}



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