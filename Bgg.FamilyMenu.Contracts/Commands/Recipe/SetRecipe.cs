using DDD.Framework.Core.CQS;

namespace Bgg.FamilyMenu.Contracts.Commands.Recipe
{
    public class SetRecipePayload
    {
        public string Id { get; set; }
        public string RecipeName { get; set; }
        public string RecipeDescription { get; set; }
    }

    public class SetRecipe : BaseCommand<SetRecipePayload> { }
}
