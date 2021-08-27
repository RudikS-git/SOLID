namespace SOLID._2._Open_Closed_Principle.Good_implementation
{
    public class Document
    {
        public string Text { get; set; }
        public IPrinter printer { get; set; }

        public void Print()
        {
            printer.Print(Text);
        }
    }
}
