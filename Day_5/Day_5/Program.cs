using System;

namespace Day_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Ievadi pirmo skaitli: ");
            double number1 = InputDouble(1);

            //Console.WriteLine("Ievadi otro skaitli: ");
            double number2 = InputDouble(2);

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
                default:
                    Console.WriteLine("invalid actin");
                    break;
            }
            
            static double InputDouble(double number)
            {
                double result = 0;
                try
                {
                    Console.WriteLine("Ievadi"+ number+".skaitli: ");
                    result= Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    result = InputDouble(number);
                }
                return result;
            }

        }
    }
}
