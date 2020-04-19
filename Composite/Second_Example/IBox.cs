namespace Composite
{
    public interface IBox
    {
        string Name { get; set; }
        int Price { get; set; }

        int GetTotalPrice();
        string GetTotalName();
    }
}