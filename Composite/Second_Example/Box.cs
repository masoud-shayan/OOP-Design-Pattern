using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Composite
{
    // Composite
    public class Box : IBox
    {
        public ICollection<IBox> _boxes;
        public string Name { get; set; }
        public int Price { get; set; }
        public Box()
        {
            _boxes = new List<IBox>();
        }

        public void AddProduct(IBox product)
        {
            _boxes.Add(product);
        } 
        
        public void RemoveProduct(IBox product)
        {
            _boxes.Remove(product);
        } 

        public int GetTotalPrice()
        {
            Price = 0;
            foreach (var box in _boxes)
            {
                Price += box.GetTotalPrice();
            }

            return Price;
        }
        
        public string GetTotalName()
        {
            Name = "";
            foreach (var box in _boxes)
            {
                Name += "  " + box.GetTotalName();
            }

            return Name;
        }
    }
}