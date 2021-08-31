namespace SOLID._3._The_Liskov_Substitution_Principle.Good_implementation
{
    public class Rectangle : Figure
    {
        public virtual int Height { get; set; }
        public virtual int Width { get; set; }

        public Rectangle(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public override int GetArea()
        {
            return Width * Height;
        }

    }
}
