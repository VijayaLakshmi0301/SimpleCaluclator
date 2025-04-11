using System;
namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double num1 = 0;
                double num2 = 0;
                double result = 0;

                Console.WriteLine("------------------");
                Console.WriteLine("Calculator Program");
                Console.WriteLine("------------------");

                Console.Write("Enter number 1: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter number 2: ");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the Option :");
                Console.WriteLine("+ : Add");
                Console.WriteLine("- : Subtract");
                Console.WriteLine("* : Multiply");
                Console.WriteLine("/ : Divide");
                Console.WriteLine("% : Remainder");
                Console.Write("Enter the Option :");
                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Your result {num1} + {num2} is " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Your result {num1} - {num2} is " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Your result {num1} * {num2} is " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Your result {num1} / {num2} is " + result);
                        break;
                    case "%":
                        result = num1 % num2;
                        Console.WriteLine($"Your result {num1} % {num2} is " + result);
                        break;
                    default:
                        Console.WriteLine("Enter valid option:");
                        break;
                }
                Console.Write("Would you like to play again (Y/N) :");
            }
            while (Console.ReadLine().ToUpper() == "Y");
            Console.WriteLine("Bye!");
            Console.ReadKey();
        }
    }
}

