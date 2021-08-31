using System;

namespace SOLID._3._The_Liskov_Substitution_Principle.Bad_implementation
{
    public class Main
    {
        public void Test(Rectangle rectangle)
        {
            rectangle.Height *= 5;
            rectangle.Width *= 10;

            rectangle.GetArea();

            // the behavior of the squares is expected to be a rectangle, but the area will be 100, not 50 
        }
    }
}
