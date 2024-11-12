using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    public static class Calculator
    {
        public static decimal ConvertNumber(this string num)
        {
            decimal.TryParse(num, out decimal numOne); return numOne;
        }

        public static bool CheckNumber(this string num)
        {
                try { int.TryParse(num, out int numOne); return true; }
                catch { return false; }
        }
        public static decimal Subtract(decimal first, decimal second)   {   return first - second;  }
        public static decimal Add(decimal first, decimal second) {   return first + second;  }
        public static decimal Divide(decimal first, decimal second) {   return first / second; }
        public static decimal Multiply(decimal first, decimal second) {    return second * first; }
        public static decimal ConvertToDecimal(this string num)
        {
            decimal.TryParse(num, out decimal numOne); return numOne;
        }
    
        public static void SubtractNumbers()
        {
            String numOne;
            String numTwo;
            do
            {
                Console.WriteLine("Subtraction Selected.");
                Console.Write("Enter First Number: ");
                numOne = Console.ReadLine();
                Console.Write("Enter Second Number: ");
                numTwo = Console.ReadLine();
                if (numOne.CheckNumber() == false || numTwo.CheckNumber() == false)
                { Console.WriteLine("Invalid Input!"); }
                
            } while (numOne.CheckNumber() == false || numTwo.CheckNumber() == false);
            decimal num1 = numOne.ConvertNumber();
            decimal num2 = numTwo.ConvertNumber();
            Console.Write($"{num1} - {num2} = ");
            Console.WriteLine(Calculator.Subtract(num1, num2));
        }

        public static void AddNumbers()
        {
            String numOne;
            String numTwo;
            do
            {
                Console.WriteLine("Addition Selected.");
                Console.Write("Enter First Number: ");
                numOne = Console.ReadLine();
                Console.Write("Enter Second Number: ");
                numTwo = Console.ReadLine();
                if (numOne.CheckNumber() == false || numTwo.CheckNumber() == false)
                { Console.WriteLine("Invalid Input!"); }

            } while (numOne.CheckNumber() == false || numTwo.CheckNumber() == false);
            decimal num1 = numOne.ConvertNumber();
            decimal num2 = numTwo.ConvertNumber();
            Console.Write($"{num1} + {num2} = ");
            Console.WriteLine(Calculator.Add(num1, num2));
        }

        public static void MultiplyNumbers()
        {
            String numOne;
            String numTwo;
            do
            {
                Console.WriteLine("Multiplication Selected.");
                Console.Write("Enter First Number: ");
                numOne = Console.ReadLine();
                Console.Write("Enter Second Number: ");
                numTwo = Console.ReadLine();
                if (numOne.CheckNumber() == false || numTwo.CheckNumber() == false)
                { Console.WriteLine("Invalid Input!"); }

            } while (numOne.CheckNumber() == false || numTwo.CheckNumber() == false);
            decimal num1 = numOne.ConvertNumber();
            decimal num2 = numTwo.ConvertNumber();
            Console.Write($"{num1} * {num2} = ");
            Console.WriteLine(Calculator.Multiply(num1, num2));
        }

        public static void DivideNumbers()
        {
            String numOne = "";
            String numTwo = "";
            do
            {
                do
                {
                    if (numOne == "0" || numTwo == "0")
                    {
                        Console.WriteLine("Can't Divide By Zero!");
                    }
                    Console.WriteLine("\nDivision Selected.");
                    Console.Write("\nEnter First Number: ");
                    numOne = Console.ReadLine();
                    Console.Write("Enter Second Number: ");
                    numTwo = Console.ReadLine();
                } while (numOne == "0" || numTwo == "0" ||numOne == "" || numTwo == "");
                if (numOne.CheckNumber() == false || numTwo.CheckNumber() == false)
                { Console.WriteLine("Invalid Input!"); }

            } while (numOne.CheckNumber() == false || numTwo.CheckNumber() == false);
            decimal num1 = numOne.ConvertNumber();
            decimal num2 = numTwo.ConvertNumber();
            Console.Write($"\n{num1} / {num2} = ");
            Console.WriteLine(Calculator.Divide(num1, num2));
        }
    }
}

