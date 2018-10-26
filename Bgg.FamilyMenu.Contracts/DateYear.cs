using System.Diagnostics.Contracts;

namespace Bgg.FamilyMenu.Contracts
{
    public class DateYear
    {
        public DateYear(int d) { Value = d; }
        public int Value { get; }


        public static implicit operator int(DateYear d) => (int)d.Value;
        public static implicit operator DateYear(int d) => new DateYear(d);

        [ContractInvariantMethod]
        protected void ObjectInvariant()
        {
            Contract.Invariant(this.Value >= 2000);
            Contract.Invariant(this.Value <= 2080);
        }
    }
}
