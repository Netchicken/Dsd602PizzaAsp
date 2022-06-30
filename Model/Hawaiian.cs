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
            Cost.Add("Small $20");
            Cost.Add("Medium $32");
            Cost.Add("Large $37");


            PizzaChef = PizzaChefName();
        }

        public override string PizzaChefName()
        {
            return "Ha Why";
        }
    }
}
