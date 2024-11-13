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
            decimal num1 = Calculator.GetNumber();
            decimal num2 = Calculator.GetNumber();
            Console.Write($"{num1} - {num2} = ");
            Console.WriteLine(Calculator.Subtract(num1, num2));
        }

        public static void AddNumbers()
        {
            decimal num1 = Calculator.GetNumber();
            decimal num2 = Calculator.GetNumber();
            Console.Write($"{num1} + {num2} = ");
            Console.WriteLine(Calculator.Add(num1, num2));
        }

        public static void MultiplyNumbers()
        {
            decimal num1 = Calculator.GetNumber();
            decimal num2 = Calculator.GetNumber();
            Console.Write($"{num1} * {num2} = ");
            Console.WriteLine(Calculator.Multiply(num1, num2));
        }

        public static void DivideNumbers()
        {
            decimal num1 = 0;
            decimal num2 = 0;
            do {
                if (num1 == 0 || num2 == 0)
                { Console.WriteLine("Can't Divide by Zero By The Way!"); }
                num1 = Calculator.GetNumber();
                num2 = Calculator.GetNumber();
            } while (num1 == 0 || num2  == 0);
            Console.Write($"\n{num1} / {num2} = ");
            Console.WriteLine(Calculator.Divide(num1, num2));
        }

        public static decimal GetNumber()
        {
            String numOne;
            do
            {
                Console.Write("\nEnter Number: ");
                numOne = Console.ReadLine();
                if (numOne.CheckNumber() == false)
                { Console.WriteLine("Invalid Input!"); }

            } while (numOne.CheckNumber() == false);
            return numOne.ConvertNumber();
        }
    }
}

