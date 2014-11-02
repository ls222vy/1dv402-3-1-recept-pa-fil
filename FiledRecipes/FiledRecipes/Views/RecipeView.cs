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
        public void Show (IRecipe recipes) 
        {
            Console.Clear();
          
            //Skriver ut receptets namn i en header
            Header = recipes.Name;
            ShowHeaderPanel();

            //Skriver ut ingredienserna
            Console.WriteLine("\nIngredienser\n============");
            foreach (Ingredient ingredient in recipes.Ingredients) 
            {
                Console.WriteLine(ingredient);
            
            }
            //Skriver ut instruktionerna
            Console.WriteLine("\nGör så här\n===============");

            foreach (var instruction in recipes.Instructions)
            {
                Console.WriteLine(instruction);
            }
        }

        public void Show(IEnumerable<IRecipe> recipes)
        {
            //Skriver ut recept, ingredienser och intruktioner
            foreach (var recipe in recipes)
            {
                Show(recipe);
                ContinueOnKeyPressed();
            }
        }
    }

     
}
