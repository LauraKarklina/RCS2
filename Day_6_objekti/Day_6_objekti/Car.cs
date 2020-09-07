using System;
using System.Collections.Generic;
using System.Text;

namespace Day_6_objekti
{
    class Car
    {
        public String brand { get; set; }
        public String model;
        public String color;

        public void Drive()
        {
            Console.WriteLine("Brum brum");
        }

        public void PrintInfo()
        {
            Console.WriteLine(color + " " + brand + " " + model);
        }
    }
}
