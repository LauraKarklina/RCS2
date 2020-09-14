using System;
using System.Collections.Generic;

namespace Day_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Task4();
        }

        static void Task4()
        {
            List<Double> lst = FileOperations.Read();

            String choice = "";

            while (choice != "0")
            {

                Console.WriteLine("1- Pievienot");
                Console.WriteLine("3- Dzest");
                Console.WriteLine("2- Saskaitit");
                Console.WriteLine("4- Videjas");


                choice = Console.ReadLine();

                switch (choice)
                {
                    case "2":
                        Sum(lst);
                        break;
                    case "1":
                        AddElement(lst);
                        break;
                    case "3":
                        RemoveElement(lst);
                        break;
                    case "4":
                        Average(lst);
                        break;
                    default:
                        Console.WriteLine("Nepareiza ievade");
                        break;
                }
            }
        }

        private static void Sum(List<double> lst)
        {
            Console.WriteLine();


            double sum = 0;
            for (int i = 0; i < lst.Count; i++)
            {
                sum += lst[i];
                Console.WriteLine(sum);
            }
            Console.WriteLine();
        }
        private static void Average(List<double> lst)
        {
            Console.WriteLine();

            double sum = 0;
            double avg = 0;
            for (int i = 0; i < lst.Count; i++)
            {
                sum += lst[i];
                avg = sum / lst.Count;
                Console.WriteLine(avg);
            }
            Console.WriteLine();
            FileOperations.Write(lst);
        }
        private static void RemoveElement(List<double> lst)
        {
            Console.WriteLine();



            if (lst.Count == 0)
            {
                Console.WriteLine("Saraksts ir tukss!");
                return;
            }

            try
            {
                Console.WriteLine("Kuru elementu velaties dzest?");
                int toDelete = Convert.ToInt32(Console.ReadLine());
                lst.RemoveAt(toDelete);
                FileOperations.Write(lst);
            }
            catch
            {
                Console.WriteLine("Kludaina ievade!");
            }


            Console.WriteLine();
        }

        private static void AddElement(List<double> lst)
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("Ievadiet elementu!");
                lst.Add(Convert.ToDouble(Console.ReadLine()));
                FileOperations.Write(lst);
            }
            catch
            {
                Console.WriteLine("invalid");
            }
            Console.WriteLine();
        }
    }
}
