using System;
using System.Collections;

namespace SOLID._3._The_Liskov_Substitution_Principle.Bad_implementation
{
    public class Squad : Rectangle
    {
        public override int Height 
        {
            get
            {
                return base.Height;
            }
            
            set
            {
                base.Height = value;
                base.Width = value;
            }
        }
        public override int Width
        {
            get
            {
                return base.Width;
            }

            set
            {
                base.Height = value;
                base.Width = value;
            }
        }
    }
}
