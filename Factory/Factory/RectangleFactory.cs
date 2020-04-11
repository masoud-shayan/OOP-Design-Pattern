namespace Factory
{
    public class RectangleFactory : ShapeFactory
    {
        public override Shape GetShape()
        {
            return new Rectangle();
        }
    }
}