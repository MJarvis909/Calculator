using System;
using static System.Math;

namespace Calculator
{
    class Program
    {
        static int number, firstNumber, secondNumber;
        public static void MenuScreen()
        {
            Console.WriteLine("Choose operation:");
            Console.WriteLine("1 - addition");
            Console.WriteLine("2 - subtraction");
            Console.WriteLine("3 - division");
            Console.WriteLine("4 - multiplication");
            Console.WriteLine("5 - exponentiation");
            Console.WriteLine("6 - modulo");
            Console.WriteLine("7 - odd numbers");
            Console.WriteLine("8 - primary numbers");
            Console.WriteLine("9 - square root");
            Console.WriteLine("10 - the natural logarithm");
            Console.WriteLine("11 - Exit");
        }

        static void enterTwoNumbers()
        {
            Console.WriteLine("Enter the first number");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            secondNumber = Convert.ToInt32(Console.ReadLine());
        }
        static void enterOneNumber()
        {
            Console.WriteLine("Enter the number");
            number = Convert.ToInt32(Console.ReadLine());
        }

        static void primaryNumbers()
        {
            for (int i = 3; i <= number; i += 2)
            {
                int h = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        h++;
                        if (h == 2 && j == i)
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int operation;

            while (true)
            {
                Console.Clear();
                MenuScreen();
                operation = Convert.ToInt32(Console.ReadLine());
                if(operation == 1)                                  //addition
                {
                    enterTwoNumbers();
                    Console.WriteLine(firstNumber+secondNumber);
                    Console.ReadKey();
                }
                else if(operation == 2)                             //subtraction
                {
                    enterTwoNumbers();
                    Console.WriteLine(firstNumber - secondNumber);
                    Console.ReadKey();
                }
                else if(operation == 3)                             //division
                {
                    enterTwoNumbers();
                    Console.WriteLine(firstNumber / secondNumber);
                    Console.ReadKey();
                }
                else if (operation == 4)                            //multiplication
                {
                    enterTwoNumbers();
                    Console.WriteLine(firstNumber * secondNumber);
                    Console.ReadKey();
                }
                else if (operation == 5)                            //exponentiation
                {
                    enterTwoNumbers();
                    Console.WriteLine(Pow(firstNumber, secondNumber));
                    Console.ReadKey();
                }
                else if (operation == 6)                            //modulo
                {
                    enterTwoNumbers();
                    Console.WriteLine(firstNumber % secondNumber);
                    Console.ReadKey();
                }
                else if (operation == 7)                            //odd numbers
                {
                    enterOneNumber();
                    for (int i = 1; i <= number; i+=2 )
                    {
                        Console.WriteLine(i);
                    }
                    Console.ReadKey();
                }
                else if (operation == 8)                            //primary numbers
                {
                    enterOneNumber();
                    primaryNumbers();
                    Console.ReadKey();
                }
                else if (operation == 9)                            //square root
                {
                    enterOneNumber();
                    Console.WriteLine(Sqrt(number));
                    Console.ReadKey();
                }
                else if (operation == 10)                           //the natural logarithm
                {
                    enterOneNumber();
                    Console.WriteLine(Log(number));
                    Console.ReadKey();
                }
                else if (operation == 11)                           //Exit
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong operation");
                    Console.ReadKey();
                }

            }
        }
    }
}
