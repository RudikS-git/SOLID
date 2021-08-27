using System;

namespace SOLID.Single_Responsibility_Principle.Good_implementation
{
    public class MailSender : ISenderMail
    {
        public void Send(string text, string mail)
        {
            Console.WriteLine($"Sending the document ('{text}') to '{mail}'");
        }

    }
}
