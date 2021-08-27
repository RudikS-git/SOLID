using System;

namespace SOLID._4._The_interface_Segregation_Principle.Bad_implementation
{
    public class SmsSender : ISender
    {
        public string Text { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Subject { get; set; }
        public string ToAddress { get; set; }
        public string FromAddress { get; set; }

        public void Send()
        {
            Console.WriteLine("Sending the SMS message");
        }
    }
}
