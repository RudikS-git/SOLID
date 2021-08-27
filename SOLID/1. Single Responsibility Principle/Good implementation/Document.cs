namespace SOLID.Single_Responsibility_Principle.Good_implementation
{
    public class Document
    {
        public string Text { get; set; }
        public string Sign { get; set; }

        public void SendByMail(ISenderMail sender, string mail)
        {
            sender.Send(Text, mail);
        }

        public void PrintConsole(IPrinter printer)
        {
            printer.Print(Text);
        }

        public void MakeSign(ISigner signer)
        {
            signer.Sign(Sign, Text);
        }
    }
}
