using System;

namespace SOLID.Single_Responsibility_Principle.Good_implementation
{
    public class ConsolePrinter : IPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine(text);
        }
    }
}
