using System;

namespace Factory
{
    public class Circle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Circle::draw() method.");
        }
    }
}