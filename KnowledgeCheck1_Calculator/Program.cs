using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KnowledgeCheck1_Calculator;

namespace KnowledgeCheck1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello. Press + for addition, - for subtraction, * for multiplication, and / for division");

            string input = Console.ReadLine();
            var calculator = new Calculator();

            var number1 = string.Empty;
            var number2 = "";
            switch (input)
            {
                case "+":
                    do
                    {
                        if (calculator.CheckNumber(number1, number2) == false)
                        { Console.WriteLine("Invalid Input! Try Again!"); }
                        Console.WriteLine("Enter 2 integers to add");
                        //calculator.GetNumbers(Console.ReadLine(), Console.ReadLine());
                        number1 = Console.ReadLine();
                        number2 = Console.ReadLine();
                    } while (calculator.CheckNumber(number1, number2) == false);
                    
                        Console.Write(calculator.Add(number1, number2));
                    break;

                case "-":
                    { 
                    do
                    {
                            if (calculator.CheckNumber(number1, number2) == false)
                            { Console.WriteLine("Invalid Input! Try Again!"); }
                            Console.WriteLine("Enter 2 integers to subtract");
                        number1 = Console.ReadLine();
                        number2 = Console.ReadLine();
                    } while(calculator.CheckNumber(number1, number2) == false);
                    
                        Console.Write(calculator.Subtract(number1, number2));
                    break;
                    }

                case "*":
                    {
                        do
                        {
                            if (calculator.CheckNumber(number1, number2) == false)
                            { Console.WriteLine("Invalid Input! Try Again!"); }
                            Console.WriteLine("Enter 2 integers to divide");
                            number1 = Console.ReadLine();
                            number2 = Console.ReadLine();
                        } while (calculator.CheckNumber(number1, number2) == false);

                        Console.Write(calculator.Multiply(number1, number2));
                        break;
                    }

                case "/":
                    {
                        do
                        {
                            if (calculator.CheckNumber(number1, number2) == false)
                            { Console.WriteLine("Invalid Input! Try Again!"); }
                            Console.WriteLine("Enter 2 integers to divide");
                            number1 = Console.ReadLine();
                            number2 = Console.ReadLine();
                        } while (calculator.CheckNumber(number1, number2) == false);

                        Console.Write(calculator.Divide(number1, number2));
                        break;
                    }

                default:
                    Console.WriteLine("Unknown input");
                    break;
            }
        }
    }
}