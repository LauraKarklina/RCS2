using System;

namespace Day_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Console.WriteLine("Ieraksti skaitli:");
            //Console.WriteLine(Task3_3());
            int sum = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter number:");
                string input = Console.ReadLine();
                int number = Convert.ToInt32(input);

                sum = sum + number;
            }
            Console.WriteLine(sum);


        }

        static bool Task3_1()
        {
            string input = Console.ReadLine();
            var number = Convert.ToInt32(input);

            bool positiveOrNegative = number > 0;
            if (positiveOrNegative)
            {
                Console.WriteLine("Skaitlis ir pozitīvs");
            }
            else
            {
                Console.WriteLine("Skaitlis ir negatīvs");
            }
            return positiveOrNegative;
        }
        static bool Task3_2()
        {
            string input = Console.ReadLine();
            var number = Convert.ToInt32(input);

            bool positiveOrNegative = number > 0;
          
            return positiveOrNegative;
        }
        static int Task3_3()
        {
            int sum = 0;
            string input = Console.ReadLine();
            var numberTimes = Convert.ToInt32(input);

            for (int i = 0; i < numberTimes; i++)
            {
                Console.WriteLine("Enter numbers:");
                string inputNumbers = Console.ReadLine();
                int numbers = Convert.ToInt32(input);

                sum = sum + numbers;
            }
            

            return sum;
        }

        static void Sample2(int number1, int number2)
        {
            Console.WriteLine("Summa ir " + (number1 + number2));
        }

        static void Sample()
        {

        }
        static void Task1()
        {
            Console.WriteLine("Enter your number: ");

            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);

            if (number > 5)

            {
                Console.WriteLine("**");
            }


            else

            {
                Console.WriteLine("*");
            }
        }
        static void Task2()
        {
            int sum = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter number:");
                string input = Console.ReadLine();
                int number = Convert.ToInt32(input);

                sum = sum + number;
            }
            Console.WriteLine(sum);


        }
    }
}
