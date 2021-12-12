using Design_Patterns_Assignment.Strategy;
using Design_Patterns_Assignment.Strategy.Messages;
using System;

namespace Design_Patterns_Assignment
{
    internal class StrategyRun
    {

        SendMessage SendMessage = new SendMessage();
        IMessage EmailMessage = new EmailMessage();
        IMessage SmsMessage = new SMSMessage();
        IMessage FacebookMessage = new FacebookMessage();


        string message = "This is a messasge";
        internal void Run()
        {
            Console.WriteLine("M : Send Message");
            Console.WriteLine("E : Send Message via Email");
            Console.WriteLine("S : Send Message via SMS");
            Console.WriteLine("F : Send Message via Facebook");
            Console.WriteLine("Q : Exit program");

            while (true)
            {
                var userInput = Console.ReadKey(true).KeyChar;

                switch (userInput)
                {
                    case 'm' or 'M':
                        ClearRow();
                        SendMessage.Send(message);
                        break;

                    case 'e' or 'E':
                        ClearRow();
                        Console.Write("Switching to the Email");
                        SendMessage.Message = EmailMessage;
                        break;

                    case 's' or 'S':
                        ClearRow();
                        Console.Write("Switching to the SMS");
                        SendMessage.Message = SmsMessage;
                        break;
                    case 'f' or 'F':
                        ClearRow();
                        Console.Write("Switching to the Facebook Message");
                        SendMessage.Message = FacebookMessage;
                        break;
                    case 'q' or 'q':
                        ClearRow();
                        Console.Write("Exiting program");
                        Environment.Exit(0);
                        break;
                    default:
                        ClearRow();
                        Console.Write("That is not a valid choice");
                        break;
                }
            }
        }
        private static void ClearRow()
        {
            // Clear Row
            Console.Write("\r" + new string(' ', Console.BufferWidth) + "\r");
        }
    }
}