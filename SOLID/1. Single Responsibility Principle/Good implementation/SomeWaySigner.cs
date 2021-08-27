using System;

namespace SOLID.Single_Responsibility_Principle.Good_implementation
{
    public class SomeWaySigner : ISigner
    {
        public void Sign(string sign, string text)
        {
            Console.WriteLine($"Signing ('{sign}') the document ('{text}')");
        }
    }
}
