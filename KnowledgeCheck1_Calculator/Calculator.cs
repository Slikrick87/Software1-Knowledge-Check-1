using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    public class Calculator
    {
        List<String> list = new List<String>();
        public int Add(string first, string second)
        {
            Console.Write($"{first.ConvertNumber()} + {second.ConvertNumber()} = ");
            return first.ConvertNumber() + second.ConvertNumber();
        }

        public int Subtract(string first, string second)
        {
            Console.Write($"{first.ConvertNumber()} - {second.ConvertNumber()} = ");
            return first.ConvertNumber() - second.ConvertNumber();

        }

        public int Multiply(string first, string second)
        {
            Console.Write($"{first.ConvertNumber()} * {second.ConvertNumber()} = ");
            return first.ConvertNumber() * second.ConvertNumber();
        }

        public double Divide(string first, string second)
        {
            Console.Write($"{first.ConvertToDecimal()} / {second.ConvertToDecimal()}");
            return first.ConvertNumber() / second.ConvertNumber();
        }
        public bool CheckNumber(string num, string num2)
        {
            try { int.TryParse(num, out int numOne); return true; }
            catch { return false; }
        }
        //public List<string> GetNumbers(string number, string number2)
        //{ list.Add (number); list.Add (number2);
        //    return list; }

    }
    public static class CalculatorExtensions
    {
        //public static bool CheckNumber(this string num, this string num2)
        //{
        //    try { int.TryParse(num, out int numOne); return true; }
        //    catch { return false; }
        //}
        public static int ConvertNumber(this string num)
        {

            int.TryParse(num, out int numOne); return numOne;
        }


        public static decimal ConvertToDecimal(this string num)
        {
            decimal.TryParse(num, out decimal numOne); return numOne;
        }
    }
}

