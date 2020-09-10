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

                double garums = 0;
                double augstums = 0;
                try
                {
                    Console.WriteLine("Norādi garumu taisnsturim nr." + i);
                    garums = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Norādi augstumu taisnsturim nr." + i);
                    augstums = Convert.ToDouble(Console.ReadLine());


                    
                }
                catch
                {
                    Console.WriteLine("Nederīga vērtība");
                    continue;
                }
                lstTaisnsturis.Add(new Taisnsturis(garums, augstums));
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

            Console.WriteLine("Figūru skaits būs te:");
            foreach (Taisnsturis taisn in lstTaisnsturis)
            {
                taisn.Laukums();
            }

            Console.WriteLine();
        }
    }
}
