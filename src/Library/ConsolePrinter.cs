using System;


namespace Full_GRASP_And_SOLID
{
    //Le agregue la interfaz para que la clase ConsolePrinter dependa de esta interfaz, en lugar de depender de la clase Recipe.
    public class ConsolePrinter : IPrinter
    {
        //Cambie Recipe por los parametros por IRecipeContent para que reciba un objeto de tipo IRecipeContent en lugar de un tipo de la clase Recipe
        public void PrintRecipe(IRecipeContent recipeContent)
        {
            Console.WriteLine(recipeContent.GetTextToPrint());
        }

    }
}
