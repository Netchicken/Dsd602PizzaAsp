namespace Dsd602PizzaAsp.Model
{
    public class Hawaiian : Pizza
    {

        public Hawaiian()
        {
            Name = "Hawaiian";
            Base = "soft base and a big crust";
            IsGlutenFree = false;
            IsVegetarian = true;
            Ingredients.Add("Pineapple");
            Ingredients.Add("Mozzarella");
            Ingredients.Add("Tomatoes");
            Image = "hawaiian.jpg";
            Cost.AddRange(PizzaCost(Ingredients.Count));
            PizzaChef = PizzaChefName();
        }

        public override string PizzaChefName()
        {
            return "Ha Why";
        }
    }
}
