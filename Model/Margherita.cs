namespace Dsd602PizzaAsp.Model
{
    public class Margherita : Pizza
    {
        public Margherita()
        {

            Base = "soft";
            IsGlutenFree = false;
            IsVegetarian = true;
            //Price = 12;
            //Size = PizzaSize.Medium;
            Ingredients.Add("Basil");
            Ingredients.Add("Mozzarella");
            Ingredients.Add("Tomatoes");
            Ingredients.Add("Oregano");
            Ingredients.Add("Evoo");


        }
    }
}
