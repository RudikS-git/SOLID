namespace SOLID._3._The_Liskov_Substitution_Principle.Good_implementation
{
    public class Main
    {
        public void MainMethod()
        {
            Figure squad = new Squad(5);
            Figure rectangle = new Rectangle(5, 10);

            // it's normal behavior now
            squad.GetArea(); // 25
            rectangle.GetArea(); // 50
        }
    }
}
