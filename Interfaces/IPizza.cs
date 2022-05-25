using Dsd602PizzaAsp.Operations;

namespace Dsd602PizzaAsp.Interfaces
{
    public interface IPizza
    {
        string? Base { get; set; }
        string? Image { get; set; }
        List<string> Ingredients { get; set; }
        bool IsGlutenFree { get; set; }
        bool IsVegetarian { get; set; }
        int PizzaType { get; set; }
        decimal Price { get; set; }
        PizzaSize Size { get; set; }
    }
}