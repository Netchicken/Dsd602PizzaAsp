namespace Dsd602PizzaAsp.Model
{
    public class Hawaiian : Pizza
    {

        public Hawaiian()
        {
            Base = "soft";
            IsGlutenFree = false;
            IsVegetarian = true;
            //Price = 12;
            //Size = PizzaSize.Medium;
            Ingredients.Add("Pineapple");
            Ingredients.Add("Mozzarella");
            Ingredients.Add("Tomatoes");
            Image = "hawaiian.jpg";
        }
    }
}
