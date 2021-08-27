using System;

namespace SOLID.Single_Responsibility_Principle.Bad_implementation
{
    // What is wrong?
    // class Document stores implementation three independent actions:
    // - send by mail
    // - print on the screen
    // - make sign
    public class Document
    {
        public string Text { get; set; }
        public string Sign { get; set; } 

        public void SendByMail(string mail)
        {
            Console.WriteLine($"Sending the document ('{Text}') to '{mail}'");
        }

        public void Print()
        {
            Console.WriteLine(Text);
        }

        public void MakeSign()
        {
            Console.WriteLine($"Signing ('{Sign}') the document ('{Text}')");
        }
    }
}
