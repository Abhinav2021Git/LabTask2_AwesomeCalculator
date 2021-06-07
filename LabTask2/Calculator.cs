using System;
using System.Collections.Generic;
using System.Text;

namespace LabTask2
{
    public class Calculator
    {
        public static double result;
        public static double num1, num2;

        public static void Addition(double n1, double n2)
        {
            try
            {
                result = Math.Round(n1 + n2, 2, MidpointRounding.AwayFromZero);
                Console.WriteLine("The Sum of {0} and {1} post rounding off 2-decimal digits(if exist) is = {2}", n1, n2, result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void Subtraction(double n1, double n2)
        {
            try
            {
                result = Math.Round((n1 - n2), 2, MidpointRounding.AwayFromZero);
                Console.WriteLine("After Subtracting {1} from {0}, the result after rounding off 2-decimal digits(if exist) is : {2}", n1, n2, result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void Multiplication(double n1, double n2)
        {
            try
            {
                result = Math.Round((n1 * n2), 2, MidpointRounding.AwayFromZero);
                Console.WriteLine("The Multiplication result of {0} and {1} post rounding off 2-decimal digits(if exist) is : {2}", n1, n2, result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void Division(double n1, double n2)
        {
            try
            {
                if (n2 != 0)
                {
                    result = Math.Round((n1 / n2), 2, MidpointRounding.AwayFromZero);
                    Console.WriteLine("The division result of {0} & {1} post rounding off 2-decimal digits(if exist) is : {2}", n1, n2, result);
                }
                else
                    Console.WriteLine("Wrong input, please try again later");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}