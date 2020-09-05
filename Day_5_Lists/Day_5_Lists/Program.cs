using System;
using System.Collections.Generic;

namespace Day_5_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> lst = new List<String>();
            Task2(lst);
        }

        static void Task2(List<String> lst)
        {
            String choice = "";

            while (choice != "exit")
            {
                Console.WriteLine("Izvēlies darību-Pievienot, Izvadīt vai exit");
                choice = Console.ReadLine();



                switch (choice)
                {
                    case "Pievienot":
                        Console.WriteLine("Cik vērtības pievienot? ");
                        int vertibuSkaits = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i < vertibuSkaits; i++)
                        {
                            Console.WriteLine("Pievieno vērtību nr." + i);
                            lst.Add(Console.ReadLine());
                        }

                        break;
                    case "Izvadit":

                        if (lst.Count == 0)
                        {
                            Console.WriteLine("Nav vērtības");
                        }
                        foreach (String value in lst)
                        {
                            Console.WriteLine(value);
                        }
                        break;

                    case "exit":
                        break;
                    default:
                        Console.WriteLine("nepareiza ievade!");
                        break;
                }


            }
        }

        static string InputString()
        {
            string darbiba = "";
            try
            {
                Console.WriteLine("Ievadiet darbibu");
                darbiba = Console.ReadLine();
            }
            catch
            {
                darbiba = InputString();
            }

            return darbiba;
        }

    }
}
