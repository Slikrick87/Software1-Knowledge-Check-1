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
            
            Console.WriteLine("Welcome To Math World New Comer!!");
            
            string input = String.Empty;
            var calculator = new Calculator();
            string quitPrompt = String.Empty;
            var number1 = string.Empty;
            var number2 = "";
            do
            {
                Console.WriteLine("Press + for addition, - for subtraction, * for multiplication, and / for division");
                input = Console.ReadLine();
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

                        Console.WriteLine(calculator.Add(number1, number2));
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
                            } while (calculator.CheckNumber(number1, number2) == false);

                            Console.WriteLine(calculator.Subtract(number1, number2));
                            break;
                        }

                    case "*":
                        {
                            do
                            {
                                if (calculator.CheckNumber(number1, number2) == false)
                                { Console.WriteLine("Invalid Input! Try Again!"); }
                                Console.WriteLine("Enter 2 integers to Multiply");
                                number1 = Console.ReadLine();
                                number2 = Console.ReadLine();
                            } while (calculator.CheckNumber(number1, number2) == false);

                            Console.WriteLine(calculator.Multiply(number1, number2));
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
                            
                            Console.WriteLine(calculator.Divide(number1, number2));
                            break;
                        }

                    default:

                        {
                            Console.WriteLine("Unknown input");
                            break;
                        }

                }
                        Console.WriteLine("Wanna Do More Math?");
                        quitPrompt = Console.ReadLine();
                
            
            } while (quitPrompt.ToLower().StartsWith("y"));
        }
    }
}