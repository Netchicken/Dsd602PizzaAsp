using Dsd602PizzaAsp.Operations;

namespace Dsd602PizzaAsp.Model
{
    public class Hawaiian : Pizza
    {

        public Hawaiian()
        {
            Base = "soft with a big edge";
            IsGlutenFree = false;
            IsVegetarian = true;
            Price = 25;
            Size = PizzaSize.Large;
            Ingredients.Add("Pineapple");
            Ingredients.Add("Mozzarella");
            Ingredients.Add("Tomatoes");
            Image = "hawaiian.jpg";
        }
    }
}
