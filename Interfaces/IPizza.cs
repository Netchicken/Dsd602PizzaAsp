﻿using Dsd602PizzaAsp.Operations;

namespace Dsd602PizzaAsp.Interfaces
{
    public interface IPizza
    {
        string? Name { get; set; }
        string? Base { get; set; }
        string? Image { get; set; }
        List<string> Ingredients { get; set; }
        bool IsGlutenFree { get; set; }
        bool IsVegetarian { get; set; }
        int? PizzaTypeSelected { get; set; }
        List<PizzaSizePrice> Cost { get; set; }
    }
}