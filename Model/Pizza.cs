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

        public Pizza()
        {
            Ingredients = new List<string>();
            Cost = new List<PizzaSizePrice>();

        }

        /// <summary>
        /// The cost of the pizza is the sze + the amount of ingredients. A medium pizza is ingredient X2 and large X3
        /// </summary>
        public List<PizzaSizePrice> PizzaCost(int ingredientCount)
        {
            List<PizzaSizePrice> Costing = new List<PizzaSizePrice>();

            PizzaSizePrice pizzaSize1 = new PizzaSizePrice();
            pizzaSize1.Price = 10 + ingredientCount;
            pizzaSize1.Size = "Small";
            Costing.Add(pizzaSize1);

            PizzaSizePrice pizzaSize2 = new PizzaSizePrice();
            pizzaSize2.Price = 20 + (ingredientCount * 2);
            pizzaSize2.Size = "Medium";
            Costing.Add(pizzaSize2);

            PizzaSizePrice pizzaSize3 = new PizzaSizePrice();
            pizzaSize3.Price = 30 + (ingredientCount * 3);
            pizzaSize3.Size = "Large";
            Costing.Add(pizzaSize3);

            return Costing;
        }


    }



}
