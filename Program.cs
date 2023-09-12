using System;

class Program
{
    private static List<IKood> iKoodList = new List<IKood>();
    private static string fileName = "ikood.txt"; 

    static void Main()
    {
        LoadIKoodFromFile(); 

        while (true)
        {
            Console.WriteLine("Vali tegevus:");
            Console.WriteLine("1. Add IKood");
            Console.WriteLine("2. Delete IKood");
            Console.WriteLine("3. Search IKood");
            Console.WriteLine("4. Exit");
            Console.Write("Sisesta valik: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddIKood();
                    break;
                case "2":
                    DeleteIKood();
                    break;
                case "3":
                    SearchIKood();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Vigane valik. Proovi uuesti.");
                    break;
            }
        }
    }

    static void AddIKood()
    {
        Console.Write("Sisesta isikukood: ");
        string idCode = Console.ReadLine();

        if (!IsValidLength(idCode))
        {
            Console.WriteLine("Liiga pikk või lühike isikukood");
        }
        else if (!idCode.All(char.IsDigit))
        {
            Console.WriteLine("Vaja ainult numbrite sisestamine");
        }
        else
        {
            iKoodList.Add(new IKood { Code = idCode });
            Console.WriteLine("Isikukood lisatud edukalt.");
            SaveIKoodToFile(); // Сохраняем IKood в файл после добавления
        }
    }

    static void DeleteIKood()
    {
        Console.Write("Sisesta isikukood, mida soovid kustutada: ");
        string idCode = Console.ReadLine();

        IKood iKoodToDelete = iKoodList.FirstOrDefault(i => i.Code == idCode);

        if (iKoodToDelete != null)
        {
            iKoodList.Remove(iKoodToDelete);
            Console.WriteLine("Isikukood kustutatud edukalt.");
            SaveIKoodToFile(); // Сохраняем IKood в файл после удаления
        }
        else
        {
            Console.WriteLine("Isikukoodi ei leitud.");
        }
    }

    static void SearchIKood()
    {
        Console.Write("Sisesta isikukood, mida soovid otsida: ");
        string idCode = Console.ReadLine();

        IKood iKoodToSearch = iKoodList.FirstOrDefault(i => i.Code == idCode);

        if (iKoodToSearch != null)
        {
            Console.WriteLine($"See on {GetGender(idCode)} ta on sündinud {GetBirthDate(idCode)}, tema sünnikoht on {HospitalService.Haigla(idCode)}");
        }
        else
        {
            Console.WriteLine("Isikukoodi ei leitud.");
        }
    }

    static bool IsValidLength(string idCode)
    {
        return idCode.Length == 11;
    }

    static string GetGender(string idCode)
    {
        char firstDigit = idCode[0];

        if (new[] { '1', '3', '5' }.Contains(firstDigit))
        {
            return "mees";
        }















































































































































































































































































































































































































































































































































        ,
        else if (new[] { '2', '4', '6' }.Contains(firstDigit))
        {
            return "naine";
        }
        else
        {
            return "viga";
        }
    }

    static string GetBirthDate(string idCode)
    {
        string year = idCode.Substring(1, 2);
        string month = idCode.Substring(3, 2);
        string day = idCode.Substring(5, 2);

        return $"{day}.{month}.{year}";
    }
    static void LoadIKoodFromFile()
    {
        if (File.Exists(fileName))
        {
            string[] lines = File.ReadAllLines(fileName);
            iKoodList = lines.Select(line => new IKood { Code = line }).ToList();
        }
    }

    
    static void SaveIKoodToFile()
    {
        File.WriteAllLines(fileName, iKoodList.Select(i => i.Code));
    }

}