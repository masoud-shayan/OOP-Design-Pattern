using System;

namespace Template
{
    public class ConcreteWallHouse : House
    {
        protected override void DecorateHouse()
        {
            Console.WriteLine("Decorating Concrete Wall House.");
        }

        protected override void PaintHouse()
        {
            Console.WriteLine("Painting Concrete Wall House.");
        }

        protected override void ConstructDoors()
        {
            Console.WriteLine("Constructing Doors for Concrete Wall House.");
        }

        protected override void ConstructWindows()
        {
            Console.WriteLine("Constructing Windows for Concrete Wall House.");
        }

        protected override void ConstructWalls()
        {
            Console.WriteLine("Constructing Concrete Wall for my House");
        }
    }
}