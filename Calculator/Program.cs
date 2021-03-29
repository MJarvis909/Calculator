using System;
using static System.Math;

namespace Calculator
{
    class Program
    {
        static int number, firstNumber, secondNumber;
        static bool loop = true;
        public static void MenuScreen()
        {
            const string ChooseOperation = "Choose operation:";
            const string Addition = "1 - addition";
            const string Subtraction = "2 - subtraction";
            const string Division = "3 - division";
            const string Multiplication = "4 - multiplication";
            const string Exponentiation = "5 - exponentiation";
            const string Modulo = "6 - modulo";
            const string OddNumbers = "7 - odd numbers";
            const string PrimaryNumbers = "8 - primary numbers";
            const string SquareRoot = "9 - square root";
            const string NaturalLogarithm = "10 - the natural logarithm";
            const string Exit = "11 - Exit";

            Console.WriteLine(ChooseOperation);
            Console.WriteLine(Addition);
            Console.WriteLine(Subtraction);
            Console.WriteLine(Division);
            Console.WriteLine(Multiplication);
            Console.WriteLine(Exponentiation);
            Console.WriteLine(Modulo);
            Console.WriteLine(OddNumbers);
            Console.WriteLine(PrimaryNumbers);
            Console.WriteLine(SquareRoot);
            Console.WriteLine(NaturalLogarithm);
            Console.WriteLine(Exit);
        }

        static void EnterTwoNumbers()
        {
            const string enterFirstNumber = "Enter the first number";
            const string enterSecondNumber = "Enter the second number";

            Console.WriteLine(enterFirstNumber);
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(enterSecondNumber);
            secondNumber = Convert.ToInt32(Console.ReadLine());
        }
        static void EnterOneNumber()
        {
            const string enterNumber = "Enter the number";

            Console.WriteLine(enterNumber);
            number = Convert.ToInt32(Console.ReadLine());
        }

        static void PrimaryNumbers()
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

            while (loop)
            {
                Console.Clear();
                MenuScreen();
                switch(Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:                                 //addition
                    
                        EnterTwoNumbers();
                        Console.WriteLine(firstNumber+secondNumber);
                        Console.ReadKey();
                        break;

                    case 2:                             //subtraction
                    
                        EnterTwoNumbers();
                        Console.WriteLine(firstNumber - secondNumber);
                        Console.ReadKey();
                        break;

                    case 3:                             //division
                    
                        EnterTwoNumbers();
                        Console.WriteLine(firstNumber / secondNumber);
                        Console.ReadKey();
                        break;

                    case 4:                            //multiplication
                    
                        EnterTwoNumbers();
                        Console.WriteLine(firstNumber * secondNumber);
                        Console.ReadKey();
                        break;

                    case 5:                            //exponentiation
                    
                        EnterTwoNumbers();
                        Console.WriteLine(Pow(firstNumber, secondNumber));
                        Console.ReadKey();
                        break;

                    case 6:                            //modulo
                    
                        EnterTwoNumbers();
                        Console.WriteLine(firstNumber % secondNumber);
                        Console.ReadKey();
                        break;

                    case 7:                            //odd numbers
                    
                        EnterOneNumber();
                        for (int i = 1; i <= number; i+=2 )
                        {
                            Console.WriteLine(i);
                        }
                        Console.ReadKey();
                        break;

                    case 8:                            //primary numbers
                    
                        EnterOneNumber();
                        PrimaryNumbers();
                        Console.ReadKey();
                        break;

                    case 9:                            //square root
                    
                        EnterOneNumber();
                        Console.WriteLine(Sqrt(number));
                        Console.ReadKey();
                        break;

                    case 10:                           //the natural logarithm
                    
                        EnterOneNumber();
                        Console.WriteLine(Log(number));
                        Console.ReadKey();
                        break;

                    case 11:                           //Exit

                        loop = false;
                        break;

                    default:
                    
                        Console.WriteLine("Wrong operation");
                        Console.ReadKey();                        
                        break;
                }
            }
        }
    }
}
