using System;

namespace series_registration
{
    class Program
    {
        static void Main(string[] args)
        {
            string option;
            do
            {
                option = ShowMenu();
                switch (option)
                {
                    case "1":
                        //ListSeries();
                        break;
                    case "2":
                        //AddSerie();
                        break;
                    case "3":
                        //UpdateSerie();
                        break;
                    case "4":
                        //DeleteSerie();
                        break;
                    case "5":
                        //ViewSerie();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    case "X":
                        Console.WriteLine("Thank you for using our services!\n");
                        break;
                    default:
                        Console.WriteLine("Invalid Option\n");
                        break;
                }

            } while (option != "X");
        }
        private static string ShowMenu()
        {
            Console.WriteLine("\n[1] List Series");
            Console.WriteLine("[2] Add Serie");
            Console.WriteLine("[3] Update Serie");
            Console.WriteLine("[4] Delete Serie");
            Console.WriteLine("[5] View Serie");
            Console.WriteLine("[c] Clear Screen");
            Console.WriteLine("[x] Exit Application");
            Console.WriteLine("Please, insert the option:");

            return Console.ReadLine().Trim().ToUpper();
        }





    }
}
