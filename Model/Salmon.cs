namespace Dsd602PizzaAsp.Model
{
    public class Salmon : Pizza
    {
        public Salmon()
        {
            Base = "soft";
            IsGlutenFree = true;
            //Price = 12;
            //Size = PizzaSize.Medium;
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
