using Dsd602PizzaAsp.Model;

namespace Dsd602PizzaAsp.Operations
{
    public static class Factory
    {
        //factory method that decides which pizza to instantiate
        public static Pizza GetAPizza(int? id)
        {
            switch (id)
            {
                case 1:
                    return new Hawaiian();
                case 2:
                    return new Margherita();
                case 3:
                    return new Salmon();

                default:
                    return new Pizza();
            }

        }

    }
}
