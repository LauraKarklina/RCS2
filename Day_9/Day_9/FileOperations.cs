using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Enumeration;
using System.Text;

namespace Day_9
{
    class FileOperations

    {
        private const String defaultPath = @"C:\Users\Laura IT\Desktop\RCS2_c_sharp\Day_9\Day_9\bin\Debug\netcoreapp3.1";
        public static void Read(String name)
        {

            try
            {
                StreamReader sr = new StreamReader(name+ defaultPath, true);

                String line = sr.ReadLine();

                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }

                sr.Close();
            }
            catch
            {
                Console.WriteLine("Neizdevas nolasit failu!");
            }
        }
        public static void Write(List<String> lst, String name)
        {

            try
            {
                StreamWriter sw = new StreamWriter("new.txt", true);

                String reverseOrder = "";
                for (int i = lst.Count - 1; i > -1; i--)
                {
                    reverseOrder += lst[i];
                }
                Console.WriteLine(reverseOrder);


                sw.Close();
            }
            catch
            {
                Console.WriteLine("Neizdevas ierakstit faila!");
            }
        }
    }
}
