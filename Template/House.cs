using System;

namespace Template
{
    public abstract class House
    {
        // template method
        public void BuildHouse()
        {
            ConstructBase();
            ConstructRoof();
            ConstructWalls();
            ConstructWindows();
            ConstructDoors();
            PaintHouse();
            DecorateHouse();
        }
        
        protected abstract void DecorateHouse();
 
        protected abstract void PaintHouse();
 
        protected abstract void ConstructDoors();
 
        protected abstract void ConstructWindows();
 
        protected abstract void ConstructWalls();

        private void ConstructBase()
        {
            Console.WriteLine("Base has been constructed.");
        }

        private void ConstructRoof()
        {
            Console.WriteLine("Roof has been constructed.");
        }
    }
}