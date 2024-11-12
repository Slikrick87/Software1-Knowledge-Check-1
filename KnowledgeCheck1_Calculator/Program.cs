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
            
            Console.WriteLine("Hey Bud, Welcome To Math World!!");
            
            string input = String.Empty;
            string quitPrompt = String.Empty;
            do
            {
                Console.WriteLine("What Type Of Problem Do You Have? (Math Only Please!)");
                Console.WriteLine("\nPlease only use the following operands.");
                Console.WriteLine("[+ addition], [- subtraction], \n[* multiplication], [/ for division]");
                input = Console.ReadLine();
                switch (input)
                {
                    case "+":
                        Calculator.AddNumbers();
                        break;
                        
                    
                    case "-":
                        {
                            Calculator.SubtractNumbers();
                            break;
                        }

                    case "*":
                        {
                            Calculator.MultiplyNumbers();
                            break;
                        }

                    case "/":
                        {
                            Calculator.DivideNumbers();
                            break;
                        }

                    default:

                        {
                            Console.WriteLine("Unknown Input Dude!");
                            break;
                        }

                }
                do
                {
                    Console.WriteLine("\nWanna Do More Math?");
                    quitPrompt = Console.ReadLine();
                } while (!quitPrompt.ToLower().StartsWith("y") && !quitPrompt.ToLower().StartsWith("n"));


            } while (quitPrompt.ToLower().StartsWith("y"));
        }
    }
}