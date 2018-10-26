using System.Diagnostics.Contracts;

namespace Bgg.FamilyMenu.Contracts
{
    public class WeekOfYear
    {
        public WeekOfYear(int d) { Value = d; }
        public int Value { get; }


        public static implicit operator int(WeekOfYear d) => (int)d.Value;
        public static implicit operator WeekOfYear(int d) => new WeekOfYear(d);

        [ContractInvariantMethod]
        protected void ObjectInvariant()
        {
            Contract.Invariant(this.Value >= 1);
            Contract.Invariant(this.Value <= 52);
        }
    }
}
