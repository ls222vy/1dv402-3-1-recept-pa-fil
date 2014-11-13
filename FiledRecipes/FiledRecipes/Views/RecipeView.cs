using FiledRecipes.Domain;
using FiledRecipes.App.Mvp;
using FiledRecipes.Properties;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FiledRecipes.Views
{
    /// <summary>
    /// 
    /// </summary>
    public class RecipeView : ViewBase, IRecipeView
    {
        public void Show (IRecipe recipe) 
        {
            Console.Clear();
          
            //Skriver ut receptets namn i en header
            Header = recipe.Name;
            ShowHeaderPanel();

            //Skriver ut ingredienserna
            Console.WriteLine("\nIngredienser\n============");
            foreach (IIngredient ingredient in recipe.Ingredients) 
            {
                Console.WriteLine(ingredient);
            
            }
            //Skriver ut instruktionerna
            Console.WriteLine("\nGör så här\n===============");

            foreach (string instruction in recipe.Instructions)
            {
                Console.WriteLine(instruction);
            }
        }

        public void Show(IEnumerable<IRecipe> recipes)
        {
            //Skriver ut recept, ingredienser och intruktioner
            foreach (IRecipe recipe in recipes)
            {
                Show(recipe);
                ContinueOnKeyPressed();
            }
        }
    }

     
}
