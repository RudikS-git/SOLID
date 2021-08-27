using System;

namespace SOLID._3._The_Liskov_Substitution_Principle.Bad_implementation
{
    public class WordDocument
    {
        private string text;

        public WordDocument() { }
        public WordDocument(string initText)
        {
            text = initText;
        }

        virtual public void EditDocument(string nextText)
        {
            text = nextText;
        }

        virtual public void ShowDocument()
        {
            Console.WriteLine(text);
        }

        public PdfDocument ConvertToPdf()
        {
            return new PdfDocument(text);
        }
    }
}
