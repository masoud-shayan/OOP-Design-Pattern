using System;
using System.Collections.Generic;

namespace Factory
{
    public class ShapeCreator
    {
        private readonly Dictionary<ShapeType, ShapeFactory> _factories;
        
        
        public ShapeCreator()
        {
            _factories = new Dictionary<ShapeType, ShapeFactory>();
            
            foreach (ShapeType shapeType in Enum.GetValues(typeof(ShapeType)))
            {
                var factory = (ShapeFactory)Activator.CreateInstance(Type.GetType("Factory." + Enum.GetName(typeof(ShapeType), shapeType) + "Factory"));
                _factories.Add(shapeType, factory);
            }
        }


        public Shape ExecuteCreation(ShapeType shapeType)
        {
            return _factories[shapeType].GetShape();
        }
    }
}