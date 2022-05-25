namespace Dsd602PizzaAsp.Model
{
    public class Pizza : IPizza
    {
        public string? Base { get; set; }
        public int PizzaType { get; set; }
        public bool IsGlutenFree { get; set; }
        public bool IsVegetarian { get; set; }
        public decimal Price { get; set; }
        public PizzaSize Size { get; set; }
        public List<string> Ingredients { get; set; }

        public string? Image { get; set; }




        public Pizza()
        {
            Ingredients = new List<string>();
        }
    }

    public enum PizzaSize
    {
        Small,
        Medium,
        Large
    }

}
