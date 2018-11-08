using System;

namespace Calculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool shouldRepeat = true;
            Calculator calc = new Calculator();

            do
            {
                PrintMenu();

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.Write("\nAdd two numbers! First number: ");
                        calc.FirstNumber = double.Parse(Console.ReadLine());
                        Console.Write("Second number: ");
                        calc.SecondNumber = double.Parse(Console.ReadLine());
                        double sum = calc.SumNumbers();
                        Console.WriteLine("\nThe sum of your numbers is: {0} \n", sum);
                        break;
                    case "2":
                        Console.Write("\nGive two numbers to multiply! First number: ");
                        calc.FirstNumber = double.Parse(Console.ReadLine());
                        Console.Write("Second number: ");
                        calc.SecondNumber = double.Parse(Console.ReadLine());
                        double product = calc.MultiplyNumbers();
                        Console.WriteLine("\nThe product of your numbers is: {0} \n", product);
                        break;
                    case "3":
                        Console.WriteLine("\nGive two numbers to add all numbers in between");
                        break;
                    case "4":
                        Console.Write("\nWrite a number to add to memory: ");
                        calc.NumberInMemory = calc.NumberInMemory + double.Parse(Console.ReadLine());
                        Console.WriteLine("\nNumber successfully added to memory! \n");
                        break;
                    case "5":
                        calc.NumberInMemory = 0.0;
                        Console.WriteLine("\nNumber in memory cleared \n");
                        break;
                    case "6":
                        Console.WriteLine("\nMemory in calculator is {0} \n", calc.NumberInMemory);
                        break;
                    case "7":
                        Console.WriteLine("\nGoodbye!");
                        shouldRepeat = false;
                        break;
                    default:
                        Console.WriteLine("Wrong input, try again");
                        break;
                }
            } while (shouldRepeat);
        }

        public static void PrintMenu()
        {
            Console.WriteLine("1. Add two numbers \n" +
                              "2. Multiply two numbers \n" +
                              "3. Sum the numbers between two numbers \n" +
                              "4. Add number to memory \n" +
                              "5. Clear memory \n" +
                              "6. Print calculator contents \n" +
                              "7. Quit \n");
        }
    }
}
