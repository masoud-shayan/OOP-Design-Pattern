using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var component = new ConcreteDecorator( new ConcreteComponent());
            component.SomeThing(); 
        }
    }
}