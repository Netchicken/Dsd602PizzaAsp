namespace Dsd602PizzaAsp.Model
{
    public class IngredientsList
    {
        public string Ingredient { get; set; }
        public double PricePerUnit { get; set; }


        public IngredientsList(string ingredient, double pricePerUnit)
        {
            Ingredient = ingredient;
            PricePerUnit = pricePerUnit;
        }
    }
}
