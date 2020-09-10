using System;
using System.Collections.Generic;

namespace Day_8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Taisnsturis> lstTaisnsturis = new List<Taisnsturis>();
            AddElement(lstTaisnsturis);
            PrintLst(lstTaisnsturis);
        }

        private static void AddElement(List<Taisnsturis> lstTaisnsturis)
        {
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    Console.WriteLine("Norādi garumu taisnsturim nr." + i);
                    int garums = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Norādi augstumu taisnsturim nr." + i);
                    int augstums = Convert.ToInt32(Console.ReadLine());


                    lstTaisnsturis.Add(new Taisnsturis(garums, augstums));
                }
                catch
                {
                    Console.WriteLine("Nederīga vērtība");
                }
            }
            
        }
        private static void PrintLst(List<Taisnsturis> lstTaisnsturis)
        {
            Console.WriteLine();

            if (lstTaisnsturis.Count == 0)
            {
                Console.WriteLine("Saraksts ir tukss!");
                return;
            }

            Console.WriteLine("Figūru skaits būs te");
            foreach (Taisnsturis stud in lstTaisnsturis)
            {
                stud.PrintInfo();
            }

            Console.WriteLine();
        }
    }
}
