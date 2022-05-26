namespace Dsd602PizzaAsp.Model
{
    public class AllIngredients
    {
        public List<IngredientsList> AllIngredientList { get; set; }

        public AllIngredients()
        {
            AllIngredientList = new List<IngredientsList>();



            AllIngredientList.Add(new IngredientsList("Pineapple", 1));
            AllIngredientList.Add(new IngredientsList("Mozzarella", 2));
            AllIngredientList.Add(new IngredientsList("Tomatoes", 1.5));

            AllIngredientList.Add(new IngredientsList("Basil", 1));
            AllIngredientList.Add(new IngredientsList("Oregano", 1));
            AllIngredientList.Add(new IngredientsList("Extra Virgin Olive Oil", 2));
            AllIngredientList.Add(new IngredientsList("Capers", 3));
            AllIngredientList.Add(new IngredientsList("Olives", 3));
            AllIngredientList.Add(new IngredientsList("Parsley", 1));

        }
    }
}
