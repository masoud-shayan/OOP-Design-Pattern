namespace Decorator
{
    public abstract class DecoratorComponent : IComponent
    {

        private readonly IComponent _component;

        public DecoratorComponent(IComponent component)
        {
            _component = component;
        }
        
        
        // a derived method from IComponent , its parent
        public virtual void SomeThing()
        {
            _component.SomeThing();
        }
    }
}