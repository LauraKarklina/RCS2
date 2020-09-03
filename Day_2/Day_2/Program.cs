using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Xml;

namespace Day_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.uzd
            /*Random rand = new Random();
            int max = 0;
            for (int i = 0; i < 10; i++)
            {
                int a = rand.Next(60);
                int maxNumber;
                
                if (a>max)
                {
                    max = a;
                }

                Console.WriteLine(max);
            }*/

            //2.uzd
            /*String result = "";
            for (int i = 0; i < 4; i++)
            {
                result += "*";
                Console.WriteLine(result);
            }*/

            /*int[] a = new int[5];
            //a[0] = 4;

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = 99;
                Console.WriteLine(a[i]);
            }*/


            //3.uzd

            int[] masivs = new int[5];

            for (int i = 0; i < masivs.Length; i++)
            {

                Console.WriteLine("Ievadi skaitli:");
                int number = Convert.ToInt32(Console.ReadLine());
                masivs[i] = number;
            }


            for (int i = 0; i < masivs.Length; i++)
            {
                Console.WriteLine( masivs[i]);

            }


            for (int j = masivs.Length - 1; j >= 0; j--)
            {

                Console.WriteLine("Masīvs apgriezts: " + masivs[j]);
            }
            Console.WriteLine();

            int[] arr2 = new int[masivs.Length + 1];

            for (int i = 0; i < masivs.Length; i++)
            {
                arr2[i] = masivs[i];
            }

            Console.WriteLine("Ievadiet masiva indeksu " + (arr2.Length - 1) + ":");
            masivs[arr2.Length - 1] = Convert.ToInt32(Console.ReadLine());













        }
    }
}
