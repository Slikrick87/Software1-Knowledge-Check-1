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
            string quitPrompt = String.Empty;
            do
            {
                Console.WriteLine("Please only use the following + for addition, - for subtraction, * for multiplication, and / for division");
                input = Console.ReadLine();
                switch (input)
                {
                    case "+":
                        GetNumbers.AddNumbers();
                        break;
                        
                    
                    case "-":
                        {
                            GetNumbers.SubtractNumbers();
                            break;
                        }

                    case "*":
                        {
                            GetNumbers.MultiplyNumbers();
                            break;
                        }

                    case "/":
                        {
                            GetNumbers.DivideNumbers();
                            break;
                        }

                    default:

                        {
                            Console.WriteLine("Unknown input");
                            break;
                        }

                }
                do
                {
                    Console.WriteLine("\nWanna Do More Math?");
                    quitPrompt = Console.ReadLine();
                } while (!quitPrompt.ToLower().StartsWith("y") || (!quitPrompt.ToLower().StartsWith("y")));


            } while (quitPrompt.ToLower().StartsWith("y"));
        }
    }
}