using System;

namespace SOLID._3._The_Liskov_Substitution_Principle.Bad_implementation
{
    public class PdfDocument : WordDocument
    {
        private string text;

        public PdfDocument() { }
        public PdfDocument(string initText)
        {
            text = initText;
        }

        // PDF cannot be changed. It's bad due to the creation returning NotImplementedException
        virtual public void EditDocument(string nextText)
        {
            throw new NotImplementedException();
        }

        virtual public void ShowDocument()
        {
            Console.WriteLine(text);
        }

        public WordDocument ConvertToWord()
        {
            return new WordDocument(text);
        }
    }
}
