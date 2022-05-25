using Dsd602PizzaAsp.Operations;

namespace Dsd602PizzaAsp.Model
{
    public class Salmon : Pizza
    {
        public Salmon()
        {
            Base = "Soft but chewy";
            IsGlutenFree = true;
            Price = 28;
            Size = PizzaSize.Large;
            Ingredients.Add("Salmon");
            Ingredients.Add("Mozzarella");
            Ingredients.Add("Tomatoes");
            Ingredients.Add("Capers");
            Ingredients.Add("Olives");
            Ingredients.Add("Parsley");
            Image = "salmon.jpg";
        }
    }
}
