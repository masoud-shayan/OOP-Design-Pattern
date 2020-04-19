using System;

namespace Composite
{
    public class Leaf : IComponent 
    {
        public void SomeThing()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("this is from Leaf");
            Console.ResetColor();
        }
    }
}