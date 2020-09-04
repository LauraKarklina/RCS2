using System;

namespace Day_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadi pirmo skaitli: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ievadi otro skaitli: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ievadi  +, -, *,/ ");
            String sign = Console.ReadLine();

            switch (sign)
            {

                case "*":
                    Console.WriteLine(Calculator.Multiplication(number1, number2));
                    break;
                case "/":
                    Console.WriteLine(Calculator.Division(number1, number2));
                    break;
                case "+":
                    Console.WriteLine(Calculator.Sum(number1, number2));
                    break;
                case "-":
                    Console.WriteLine(Calculator.Subtraction(number1, number2));
                    break;
            }

        }
    }
}
