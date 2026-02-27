using System;
using System.Collections.Generic;
using System.Text;

partial class Recipe
{
    public readonly string Name;
    public readonly int Servings;
    public string[] grediants;
    public int quantity;
    public int maxQuantity;

    public Recipe(string name, int servings, int quantity)
    {
        Name = name;
        Servings = servings;
        maxQuantity = quantity;
        grediants =new string[maxQuantity];

        Console.WriteLine($"=== {name} ({servings}인분)");
    }
}
