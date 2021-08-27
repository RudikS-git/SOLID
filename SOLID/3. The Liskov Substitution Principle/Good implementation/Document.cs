using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._3._The_Liskov_Substitution_Principle.Good_implementation
{
    public abstract class Document
    {
        public abstract void EditDocument(string nextText);
        public abstract void ShowDocument();
    }
}
