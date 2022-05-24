namespace Dsd602PizzaAsp.Model
{
    public class Margherita : Pizza
    {
        public Margherita()
        {

            Base = "soft and delicate";
            IsGlutenFree = false;
            IsVegetarian = true;
            Price = 24;
            Size = PizzaSize.Medium;
            Ingredients.Add("Basil");
            Ingredients.Add("Mozzarella");
            Ingredients.Add("Tomatoes");
            Ingredients.Add("Oregano");
            Ingredients.Add("Evoo");
            Image = "margherita.jpg";

        }
    }
}
