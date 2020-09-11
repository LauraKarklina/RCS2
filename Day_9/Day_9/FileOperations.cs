using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day_9
{
    class FileOperations

    {
        private const String defName = @"C:\Users\Laura IT\Desktop\C_sharp\RCS2\Day_9\Day_9\bin\Debug\netcoreapp3.1";
        public static void Read(String name)
        {
            try
            {
                StreamReader sr = new StreamReader(name+defName);

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
        public static void Write(String name)
        {

            try
            {
                StreamWriter sw = new StreamWriter(name+defName, true);
                sw.WriteLine("some text");
                

                sw.Close();
            }
            catch
            {
                Console.WriteLine("Neizdevas ierakstit faila!");
            }
        }
    }
}
