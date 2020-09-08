using System;
using System.Collections.Generic;
using System.Text;

namespace Day_7
{
    class Car
    {
        public String brand { get; set; }
        public String model { get; set; }
        public String color { get; set; }

        public Car(String brand, String model, String color)
        {
            this.brand = brand;
            this.model = model;
            this.color = color;
        }
        public Car()
        {
            brand = "def";
            model = "def";
            color = "def";
        }

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
