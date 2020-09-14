using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day_10
{
    class FileOperations
    {
        private const String defaultPath = @"C:\Users\Laura IT\Desktop\";
        private const String filename = "Test.txt";
        public static List<double> Read()
        {
            List<double> lstOfElements = new List<double>();
            try
            {

                StreamReader sr = new StreamReader(defaultPath + filename);
                
                double line = Convert.ToDouble( sr.ReadLine());

                while (line != 0)
                {
                    lstOfElements.Add(line);
                    line = Convert.ToDouble(sr.ReadLine());
                }

                sr.Close();
            }
            catch
            {
                Console.WriteLine("Neizdevas nolasit failu!");
            }

            return lstOfElements;
        }

        public static void Write(List<double> lst)
        {

            try
            {
                StreamWriter sw = new StreamWriter(defaultPath + filename);

                foreach (double el in lst)
                {
                    sw.WriteLine(el);
                }

                sw.Close();
            }
            catch
            {
                Console.WriteLine("Neizdevas ierakstit faila!");
            }
        }
    }

}
