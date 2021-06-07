using System;

namespace LabTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("::::::Awesome Calculator:::::");
                Console.WriteLine("-----Menu options are as follows-------");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("0. Exit");

                Console.WriteLine("Hey User! Which operation you would like to perform?:");
                int choice = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter your 1st number here:");
                Calculator.num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter your 2nd number here:");
                Calculator.num2 = Convert.ToDouble(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        Calculator.Addition(Calculator.num1, Calculator.num2);
                        break;

                    case 2:
                        Calculator.Subtraction(Calculator.num1, Calculator.num2);
                        break;

                    case 3:
                        Calculator.Multiplication(Calculator.num1, Calculator.num2);
                        break;

                    case 4:
                        Calculator.Division(Calculator.num1, Calculator.num2);
                        break;

                    case 0:
                        break;

                    default:
                        Console.WriteLine("Sorry you have entered some wrong value(s) !!");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
        }
}
