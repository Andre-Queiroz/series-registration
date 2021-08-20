using System;

namespace series_registration
{
    class Program
    {
        static SerieRepository repository = new SerieRepository();
        static void Main(string[] args)
        {
            string option;
            do
            {
                option = ShowMenu();
                switch (option)
                {
                    case "1":
                        ListSeries();
                        break;
                    case "2":
                        AddSerie();
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

        private static void ListSeries()
        {
            Console.WriteLine("\nSeries List:");
            var list = repository.List();

            if (list.Count == 0)
            {
                Console.WriteLine("There are no registered series");
                return;
            }

            foreach (Serie serie in list)
            {
                Console.WriteLine("\n\tId: " + serie.GetId());
                Console.WriteLine("\tTitle: " + serie.GetTitle());
            }
        }

        private static void AddSerie()
        {
            Console.WriteLine("\nAdd new serie:");

            foreach (int i in Enum.GetValues(typeof(Genre)))
            {
                Console.WriteLine($"{i} - {Enum.GetName(typeof(Genre), i)}");
            }

            Console.WriteLine("\nEnter the genre:");
            int genre = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter the title:");
            string title = Console.ReadLine();

            Console.WriteLine("\nEnter the description:");
            string description = Console.ReadLine();

            Console.WriteLine("\nEnter the year:");
            int year = int.Parse(Console.ReadLine());


            Serie newSerie = new Serie(repository.GetNextId(), (Genre)genre, title, description, year);
            repository.Add(newSerie);
        }

        private static void UpdateSerie()
        {

        }

        private static void DeleteSerie()
        {

        }

        //private static Serie ViewSerie()
        //{
        //
        //}





    }
}
