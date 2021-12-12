using Design_Patterns_Assignment;
using Design_Patterns_Assignment.Decorator;
using Design_Patterns_Assignment.Decorator.Decorators;
using System;
using static System.Net.Mime.MediaTypeNames;

namespace Design_Patterns_Assignment
{
    internal class DecoratorRun
    {
        public IText text;
        public static void SetDescription(IText text)
        {
            bool validInput = false;
            while (!validInput)
            {
                Console.WriteLine("Enter the text that you want to decorate:");
                string userInput = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(userInput))
                {
                    validInput = true;
                    text.Description = userInput;
                    Console.WriteLine("Enter the tags you want for decoration on the selected text");
                }
            }
        }
        internal void Run()
        {
            text = new Decorator.Text();
            // Refactor this code so that it uses the Decorator Pattern
            Console.WriteLine("Decorator");
            Console.WriteLine("Please enter the text.");
            Console.WriteLine();
            Console.WriteLine("F : Finnish");
            Console.WriteLine("B : Bold");
            Console.WriteLine("D : Deleted");
            Console.WriteLine("E : Emphasized");
            Console.WriteLine("I : Important");
            Console.WriteLine("N : Inserted");
            Console.WriteLine("T : Italic");
            Console.WriteLine("M : Marked");
            Console.WriteLine("S : Smaller");
            Console.WriteLine("U : SubScript");
            Console.WriteLine("P : SuperScript");
            Console.WriteLine();
            Console.WriteLine("Type the tags you want separated by space");
            SetDescription(text);

            // skapa en decorator
            // stoppa in base i decorator
            // stoppa in decoratorn i en annan decorator
            // anropa getdescription från den yttersta decoratorn           


            while (true)
            {
                var userInput = Console.ReadKey(true).KeyChar;
                switch (userInput)
                {
                    case 'f' or 'F':
                        ClearRow();
                        Console.WriteLine($"Text generated: {text.GetDescription()}");
                        text = new Decorator.Text();
                        break;
                    case 'b' or 'B':
                        ClearRow();
                        Console.WriteLine($"Added bold");
                         text = new Bold(text);
                        break;
                    case 'd' or 'D':
                        ClearRow();
                        Console.WriteLine($"Added deleted");
                        text = new Deleted(text);
                        break;
                    case 'e' or 'E':
                        ClearRow();
                        Console.WriteLine($"Added Emphasized");
                        text = new Emphasized(text);
                        break;
                    case 'i' or 'I':
                        ClearRow();
                        Console.WriteLine($"Added Important");
                        text = new Important(text);
                        break;
                    case 'n' or 'N':
                        ClearRow();
                        Console.WriteLine($"Added Inserted");
                        text = new Inserted(text);
                        break;
                    case 't' or 'T':
                        ClearRow();
                        Console.WriteLine($"Added Italic");
                        text = new Italic(text);
                        break;
                    case 'm' or 'M':
                        ClearRow();
                        Console.WriteLine($"Added Marked");
                        text = new Marked(text);
                        break;
                    case 's' or 'S':
                        ClearRow();
                        Console.WriteLine($"Added Smaller");
                        text = new Smaller(text);
                        break;
                    case 'u' or 'U':
                        ClearRow();
                        Console.WriteLine($"Added SubScript");
                        text = new Subscript(text);
                        break;
                    case 'p' or 'P':
                        ClearRow();
                        Console.WriteLine($"Added SuperScript");
                        text = new Superscript(text);
                        break;

                }
            }
        }

        private static void ClearRow()
        {
            Console.Write("\r" + new string(' ', Console.BufferWidth) + ("\r"));
        }
    }

    
}