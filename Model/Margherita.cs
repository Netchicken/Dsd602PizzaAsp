namespace Dsd602PizzaAsp.Model
{
    public class Margherita : Pizza
    {
        public Margherita()
        {
            Name = "Margherita";
            Base = "soft base and delicate crust";
            IsGlutenFree = false;
            IsVegetarian = true;

            Ingredients.Add("Basil");
            Ingredients.Add("Mozzarella");
            Ingredients.Add("Tomatoes");
            Ingredients.Add("Oregano");
            Ingredients.Add("Extra Virgin Olive Oil");
            Image = "margherita.jpg";
            //   Cost.AddRange(PizzaCost(Ingredients.Count));

            Cost.Add("Small $25");
            Cost.Add("Medium $35");
            Cost.Add("Large $37");
            PizzaChef = PizzaChefName();

        }



        public override string PizzaChefName()
        {
            return "Ma Gar Rita";
        }
    }
}
