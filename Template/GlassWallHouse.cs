using System;

namespace Template
{
    public class GlassWallHouse : House
    {
        protected override void DecorateHouse()
        {
            Console.WriteLine("Decorating Glass Wall House.");
        }

        protected override void PaintHouse()
        {
            Console.WriteLine("Painting Glass Wall House.");
        }

        protected override void ConstructDoors()
        {
            Console.WriteLine("Constructing Doors for Glass Wall House.");
        }

        protected override void ConstructWindows()
        {
            Console.WriteLine("Constructing Windows for Glass Wall House.");
        }

        protected override void ConstructWalls()
        {
            Console.WriteLine("Constructing Glass Wall for my House");
        }
    }
}