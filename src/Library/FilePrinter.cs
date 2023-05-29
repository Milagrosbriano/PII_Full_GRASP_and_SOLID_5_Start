using System.IO;

namespace Full_GRASP_And_SOLID
{
    public class FilePrinter : IPrinter
    {
        //Cambie Recipe por los parametros por IRecipeContent para que reciba un objeto de tipo IRecipeContent en lugar de un tipo de la clase Recipe
       public void PrintRecipe(IRecipeContent recipeContent)
       {
        File.WriteAllText("Recipe.txt", recipeContent.GetTextToPrint());
       }
    }
}
