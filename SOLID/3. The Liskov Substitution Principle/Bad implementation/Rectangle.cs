using System;
using System.Collections;

namespace SOLID._3._The_Liskov_Substitution_Principle.Bad_implementation
{
    public class Rectangle
    {
        public virtual int Height { get; set;}
        public virtual int Width { get; set; }
    
        public int GetArea()
        {
            return Width * Height;
        }
    }
}
