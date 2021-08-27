using System;

namespace SOLID._2._Open_Closed_Principle.Good_implementation
{
    public class ConsolePrinter : IPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine(text);
        }
    }
}
