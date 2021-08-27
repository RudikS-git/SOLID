using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._3._The_Liskov_Substitution_Principle.Good_implementation
{
    public class PdfDocument : Document
    {
        private string text;

        public PdfDocument() { }
        public PdfDocument(string initText)
        {
            text = initText;
        }

        // PDF cannot be changed
        public override void EditDocument(string nextText)
        {
            throw new NotImplementedException();
        }

        public override void ShowDocument()
        {
            Console.WriteLine(text);
        }

        public WordDocument ConvertToWord()
        {
            return new WordDocument(text);
        }
    }
}
