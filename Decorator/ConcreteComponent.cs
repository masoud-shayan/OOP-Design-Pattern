using System;

namespace Decorator
{
    public class ConcreteComponent : IComponent
    {
        public void SomeThing()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("this method wrote for the first time of creation of the component");
            Console.ResetColor();
        }
    }
}