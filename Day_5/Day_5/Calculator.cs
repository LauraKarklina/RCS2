using System;
using System.Collections.Generic;
using System.Text;

namespace Day_5
{
    class Calculator
    {
        static double Multiplication(double number1, double number2)
        {
            String sign = Console.ReadLine();
            double result = 0;
            if (sign == "*")
            {
                result = number1 * number2;
            }


            return result;
        }
        static double Division(double number1, double number2)
        {
            String sign = Console.ReadLine();
            double result = 0;


            if (sign == "/")
            {
                if (number1 > number2)
                {
                    result = number1 / number2;

                }
                else
                {
                    result = number2 / number1;
                }

            }


            return result;
        }
        static double Sum(double number1, double number2)
        {
            String sign = Console.ReadLine();
            double result = 0;
            if (sign == "+")
            {
                result = number1 + number2;
            }

            return result;
        }
        static double Subtraction(double number1, double number2)
        {
            String sign = Console.ReadLine();
            double result = 0;
            if (sign == "-")
            {
                result = number1 - number2;
            }

            return result;
        }

    }



}
