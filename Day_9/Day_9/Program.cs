using System;

namespace Day_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadiet faila nosaukumu:");
            String name = Console.ReadLine();

            FileOperations.Write(name);

            FileOperations.Read(name);
        }
    }
}
