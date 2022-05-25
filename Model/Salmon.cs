namespace Dsd602PizzaAsp.Model
{
    public class Salmon : Pizza
    {
        public Salmon()
        {
            Name = "Salmon";
            Base = "Soft base and chewy crust";
            IsGlutenFree = true;

            Ingredients.Add("Salmon");
            Ingredients.Add("Mozzarella");
            Ingredients.Add("Tomatoes");
            Ingredients.Add("Capers");
            Ingredients.Add("Olives");
            Ingredients.Add("Parsley");
            Image = "salmon.jpg";
            Cost.AddRange(PizzaCost(Ingredients.Count));
        }
    }
}
