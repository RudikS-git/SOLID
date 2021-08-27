using System;

namespace SOLID._2._Open_Closed_Principle.Bad_implementation
{
    public class ConsolePrinter
    {
        public void Print(string text)
        {
            Console.WriteLine(text);
        }
    }
}
