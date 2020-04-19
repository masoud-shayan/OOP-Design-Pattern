namespace Composite
{
    // Leaf
    public class Product : IBox
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public Product(string name , int price)
        {
            Name = name;
            Price = price;
        }

        public int TotalPrice()
        {
            return Price;
        }
        
        public int GetTotalPrice()
        {
            return Price;
        }
        
        public string GetTotalName()
        {
            return Name;
        }
    }
}