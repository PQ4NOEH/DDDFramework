using DDD.Framework.Core.CQS;

namespace Bgg.FamilyMenu.Contracts.Commands.Recipe
{
    public class RecipyIngredientPayLoad
    {
        public string RecipyRef { get; set; }
        public string IngredientRef { get; set; }
        public float Quantity { get; set; }
        public string UnitOfMeasureRef { get; set; }
    }

    public class SetIngredient : BaseCommand<RecipyIngredientPayLoad> { }

    public class RemoveRecipyIngredientPayLoad
    {
        public string RecipyRef { get; set; }
        public string IngredientRef { get; set; }
    }

    public class RemoveIngredient : BaseCommand<RemoveRecipyIngredientPayLoad> { }

}
