using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._3._The_Liskov_Substitution_Principle.Good_implementation
{
    public class WordDocument : Document
    {
        private string text;

        public WordDocument() { }
        public WordDocument(string initText)
        {
            text = initText;
        }

        public override void EditDocument(string nextText)
        {
            text = nextText;
        }

        public override void ShowDocument()
        {
            Console.WriteLine(text);
        }

        public PdfDocument ConvertToPdf()
        {
            return new PdfDocument(text);
        }
    }
}
