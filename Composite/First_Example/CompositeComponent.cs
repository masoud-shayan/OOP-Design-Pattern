using System.Collections;
using System.Collections.Generic;

namespace Composite
{
    public class CompositeComponent : IComponent
    {
        private readonly ICollection<IComponent> _children;

        public CompositeComponent()
        {
            _children = new List<IComponent>();
        }

        
        public void AddComponent(IComponent component)
        {
            _children.Add(component);
        }

        
        public void RemoveComponent(IComponent component)
        {
            _children.Remove(component);
        }

        
        public void SomeThing()
        {
            foreach (var child in _children)
            {
                child.SomeThing();
            }
        }
    }
}