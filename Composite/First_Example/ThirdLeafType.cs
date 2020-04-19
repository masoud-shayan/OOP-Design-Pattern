using System;

namespace Composite
{
    public class ThirdLeafType : IComponent
    {
        public void SomeThing()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("this is from ThirdLeafType");
            Console.ResetColor();
        }  
    }
}