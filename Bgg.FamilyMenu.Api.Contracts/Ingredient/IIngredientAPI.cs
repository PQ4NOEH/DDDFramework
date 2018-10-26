using Bgg.FamilyMenu.Contracts.Commands.Ingredient;
using DDD.Framework.Core;

namespace Bgg.FamilyMenu.Api.Contracts.Ingredient
{
    public interface IIngredientAPI
    {
        IApiResult<string> Handle(SetIngredient command);
    }
}
