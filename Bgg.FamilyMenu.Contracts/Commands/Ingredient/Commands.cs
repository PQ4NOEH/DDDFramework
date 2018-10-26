using DDD.Framework.Core.CQS;

namespace Bgg.FamilyMenu.Contracts.Commands.Ingredient
{
    public class IngredientPayload
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public uint Calories { get; set; } 
    }

    public class SetIngredient : BaseCommand<IngredientPayload> { }

}
