namespace Dsd602PizzaAsp.NotUsed
{

    public class PizzaSizePrice
    {
        public string Size { get; set; } = "Small";
        public decimal Price { get; set; }

        public PizzaSizePrice(string size, decimal price)
        {
            Size = size;
            Price = price;
        }
    }


}
