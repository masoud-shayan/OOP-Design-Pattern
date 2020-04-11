using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            new ShapeCreator().ExecuteCreation(ShapeType.Square).Draw();
        }
    }
}