using System;

namespace Composite
{
    public class SecondTypeOfLeaf : IComponent
    {
        public void SomeThing()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("this is from SecondTypeOfLeaf");
            Console.ResetColor();
        }
    }
}