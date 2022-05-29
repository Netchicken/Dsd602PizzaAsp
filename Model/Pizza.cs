using Dsd602PizzaAsp.Interfaces;
using Dsd602PizzaAsp.Operations;

namespace Dsd602PizzaAsp.Model
{
    public class Pizza : IPizza
    {
        public string? Name { get; set; }
        public string? Base { get; set; } //what is the base made of?
        public int? PizzaTypeSelected { get; set; } //for the selectlist type of pizza
        public bool IsGlutenFree { get; set; }
        public bool IsVegetarian { get; set; }
        public List<string> Ingredients { get; set; }
        public List<PizzaSizePrice> Cost { get; set; }
        public string? Image { get; set; }
        public string PizzaChef { get; set; }

        public Pizza()
        {
            Ingredients = new List<string>();
            Cost = new List<PizzaSizePrice>();
            PizzaChef = PizzaChefName();

        }

        /// <summary>
        /// The cost of the pizza is the size + the amount of ingredients. A medium pizza is ingredient X2 and large X3
        /// 
        /// OK I know counting ingredients is not a good way to work out cost. But its the code thats important, not the reality. One ingredient = $1.
        /// </summary>
        public List<PizzaSizePrice> PizzaCost(int ingredientCount)
        {
            List<PizzaSizePrice> Costing = new List<PizzaSizePrice>();


            Costing.Add(new PizzaSizePrice("Small", 10 + ingredientCount));
            Costing.Add(new PizzaSizePrice("Medium", 20 + (ingredientCount * 2)));
            Costing.Add(new PizzaSizePrice("Large", 30 + (ingredientCount * 3)));

            return Costing;
        }


        // Declared virtual so it can be overridden.
        public virtual string PizzaChefName()
        {
            return "Pizza John";
        }

    }



}
