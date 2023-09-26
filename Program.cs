using System;

namespace isikukood
{
    internal class Program
    {

        static void Main()
        {


            IKood ikood = new IKood();
            IKood.LoadIKoodFromFile();

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
                        IKood.AddIKood();
                        break;
                    case "2":
                        IKood.DeleteIKood();
                        break;
                    case "3":
                        IKood.SearchIKood();
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
    }
}
