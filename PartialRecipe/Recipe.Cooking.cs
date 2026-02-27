using System;
using System.Collections.Generic;
using System.Text;

partial class Recipe
{
    public void AddIngredient(string ingredient)
    {
        if (maxQuantity == quantity)
            Console.WriteLine("재료가 가득 찼습니다.");
        else
        {
            grediants[quantity] = ingredient;
            quantity++;

            
        }
    }

    public void PrintRecipe()
    {
        Console.WriteLine("재료: ");
        for (int i = 0; i < grediants.Length; i++)
        {
            Console.WriteLine($"  {i + 1}. {grediants[i]}");
        }
    }

    public bool Hasingredients(string ingredient)
    {
        return Array.IndexOf(grediants, ingredient) != -1;
    }
}