using System;
using System.Collections.Generic;

namespace Day_9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> lst = new List<String> { "a", "b", "c", "d" };

            String name = "new.txt";
            FileOperations.Write(lst, "new.txt");

            FileOperations.Read(name);
        }
    }
}
