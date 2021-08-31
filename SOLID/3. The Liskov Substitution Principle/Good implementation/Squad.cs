namespace SOLID._3._The_Liskov_Substitution_Principle.Good_implementation
{
    public class Squad : Figure
    {
        public int Side { get; set; }

        public Squad(int side)
        {
            Side = side;
        }

        public override int GetArea()
        {
            return Side * Side;
        }
    }
}
