namespace Factory
{
    public class CircleFactory : ShapeFactory
    {
        public override Shape GetShape()
        {
            return new Circle();
        }
    }
}