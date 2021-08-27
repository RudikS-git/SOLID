namespace SOLID._2._Open_Closed_Principle.Bad_implementation
{
    public class Document
    {
        public string Text { get; set; }
        public ConsolePrinter printer { get; set; }
        // It's depends on ConsolePrinter. Not flexible if want to add new type of printer in run time
        // public PixelPrinter printer { get; set; }

        public void Print()
        {
            printer.Print(Text);
        }
    }
}
