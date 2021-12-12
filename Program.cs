using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator! +-x/");

            bool running = true;
            char menuChoice;

            while(running)
            {
                PrintInstructions();
                Char.TryParse(Console.ReadLine(), out menuChoice);

                switch(menuChoice)
                {
                    case '0':
                        Console.WriteLine("\nYou chose to exit the program. Bye!");
                        running = false;
                        break;

                    case '+':
                        Console.WriteLine("\nYou chose +, Addition");
                        PerformAddition();
                        break;

                    case '-':
                        Console.WriteLine("\nYou chose -, Subtraction");
                        PerformSubtraction();
                        break;

                    case 'x':
                        Console.WriteLine("\nYou chose x, Multiplication");
                        PerformMultiplication();
                        break;

                    case '/':
                        Console.WriteLine("\nYou chose /, Division");                       
                        PerformDivision();
                        break;

                    default:
                        Console.WriteLine("\ninvalid menu choice!");
                        break;
                }
            }
        }

        static void PrintInstructions()
        {
            Console.WriteLine("\nWhat do you want to calculate?");
            Console.WriteLine("You have the following options: \n" +
                                "+\n" +
                                "-\n" +
                                "x\n" +
                                "/\n" +
                                "0 : Exit program");
        }

        static double GetDouble()
        {
            double inputDouble = 0;
            bool readSuccess = false;

            while (!readSuccess)
            {
                Console.WriteLine("Write a number: ");

                readSuccess = Double.TryParse(Console.ReadLine(), out inputDouble);
            }

            return inputDouble;
        }

        static void PerformAddition()
        {
            Console.WriteLine("Give the program 2 numbers to add together:");

            double add1 = GetDouble();
            double add2 = GetDouble();

            Console.WriteLine("{0} {1} {2} {3} {4}", add1, "+", add2, "=", add1 + add2);
        }

        static void PerformSubtraction()
        {
            Console.WriteLine("Give the program 2 numbers to subtract:");

            double sub1 = GetDouble();
            double sub2 = GetDouble();

            Console.WriteLine("{0} {1} {2} {3} {4}", sub1, "-", sub2, "=", sub1 - sub2);
        }

        static void PerformMultiplication()
        {
            Console.WriteLine("Give the program 2 numbers to multiply:");

            double mult1 = GetDouble();
            double mult2 = GetDouble();

            Console.WriteLine("{0} {1} {2} {3} {4}", mult1, "x", mult2, "=", mult1 * mult2);
        }

        static void PerformDivision()
        {
            Console.WriteLine("Give the program 2 numbers to divide:");

            bool divideByZeroCheck = true;
            double div1 = GetDouble();
            double div2 = 0;

            while (divideByZeroCheck)
            {
                div2 = GetDouble();
                if (div2 != 0.0)
                    divideByZeroCheck = false;
                else
                    Console.WriteLine("You can't divide by zero! Try a different number!");
            }

            Console.WriteLine("{0} {1} {2} {3} {4}", div1, "/", div2, "=", div1 / div2);
        }
    }
}
