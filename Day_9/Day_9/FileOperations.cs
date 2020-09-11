using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day_9
{
    class FileOperations
    {
        public static void Read(String name)
        {
            try
            {
                StreamReader sr = new StreamReader(name+"test.txt");

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
                StreamWriter sw = new StreamWriter(name+"Test.txt", true);
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
