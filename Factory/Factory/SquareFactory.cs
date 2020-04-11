namespace Factory
{
    public class SquareFactory : ShapeFactory
    {
        public override Shape GetShape()
        {
            return new Square();
        }
    }
}