using System;

namespace Decorator
{
    public class ConcreteDecorator : DecoratorComponent
    {
        public ConcreteDecorator(IComponent component) : base(component)
        {
        }
        
        // its own method
        public void SomeThingElse()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("then we write this method to add a new functionality(behavior) to ConcreteComponent without inheritance");
            Console.ResetColor();
        }
        
        // a derived method from DecoratorComponent from IComponent , its parent
        public void SomeThing()
        {
            base.SomeThing(); // from the IComponent
            
            this.SomeThingElse(); // add its own behavior to the ConcreteComponent 
        }
    }
}