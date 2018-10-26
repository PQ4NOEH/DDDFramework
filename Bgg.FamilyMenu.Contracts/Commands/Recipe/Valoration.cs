using DDD.Framework.Core.CQS;
using System.Diagnostics.Contracts;

namespace Bgg.FamilyMenu.Contracts.Commands.Recipe
{
    public class RecipeValoration
    {
        public string RecipyRef { get; set; }
        public Puntuation Valoration { get; set; }
        public string Notes { get; set; }
    }

    public class SetRecipeValoration : BaseCommand<RecipeValoration> { }

    public class Puntuation
    {
        public Puntuation(int d) { Value = d; }
        public Puntuation(float d) { Value = d; }
        public float Value { get; }

        public static implicit operator float(Puntuation d) => d.Value;
        public static implicit operator int(Puntuation d) => (int)d.Value;

        public static implicit operator Puntuation(float d) => new Puntuation(d);
        public static implicit operator Puntuation(int d) => new Puntuation(d);

        [ContractInvariantMethod]
        protected void ObjectInvariant()
        {
            Contract.Invariant(this.Value >= 0);
            Contract.Invariant(this.Value <= 10);
        }
    }
}
