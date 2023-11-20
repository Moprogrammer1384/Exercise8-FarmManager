using FarmManaging.Model.Classes;
using FarmManaging.Model.Interfaces;
using System.Globalization;

AnimalRepository AnimalRepository = new AnimalRepository();
IncomeManager IncomeManager = new IncomeManager(AnimalRepository);
ProfitManager ProfitManager = new ProfitManager(AnimalRepository, IncomeManager, new CostManager());
string Path = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory + @"..\..\..\Data", "AnimalsList.json");

void GenerateAnimals()
{
    if (File.Exists(Path))
    {
        String JSONtxt = File.ReadAllText(Path);
        var Animals = Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<Animal>>(JSONtxt);

        foreach (var Animal in Animals)
        {
            AnimalRepository.AddAnimal(Animal);
        }
    }
}

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
    GenerateAnimals();
    do
    {
        Welcome();
        Console.Write("Please choose one of the options: ");
        List<(int ID, string Name, string Gender, int Age, bool IsSick, decimal Profit)> Datas;
        switch (Console.ReadLine())
        {
            case "1":
                Datas = ProfitManager.DailyProfit();
                Print(Datas, "Daily Profit");
                break;
            case "2":
                Datas = IncomeManager.MeatIncome();
                Print(Datas, "Meat Profit");
                break;
            case "3":
                Datas = IncomeManager.CalvesIncome();
                Print(Datas, "Calves Profit");
                break;
            case "4":
                Datas = ProfitManager.LifeTimeProfit();
                Print(Datas, "Life Time Profit");
                break;
            case "5":
                Console.Write("Please enter a year: ");
                string Input = Console.ReadLine();
                int Year = 0;
                if (IsInt(Input) && IsNull(Input))
                {
                    Year = Convert.ToInt32(Input);
                    Datas = ProfitManager.ProfitPredicting(Year);
                    Print(Datas, "Predicted Profit");
                }                    
                else
                    Console.WriteLine("Please enter a correct number!!!");
                
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

bool IsInt(string Input)
{
    foreach (char c in Input)
    {
        if (!Char.IsDigit(c))
        {
            return false;
        }
    }
    return true;
}

bool IsNull(string Input)
{
    if (Input.Trim() == "")
        return false;
    else
        return true;
}

SelectOption();