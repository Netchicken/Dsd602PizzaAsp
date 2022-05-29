namespace Dsd602PizzaAsp.Operations
{

    public class PizzaSizePrice
    {
        public String Size { get; set; } = "Small";
        public decimal Price { get; set; }

        public PizzaSizePrice(string size, decimal price)
        {
            Size = size;
            Price = price;
        }
    }


}
