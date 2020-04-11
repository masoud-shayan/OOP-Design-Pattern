using System;

namespace Factory
{
    public class Square : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Square::draw() method.");
        }
    }
}