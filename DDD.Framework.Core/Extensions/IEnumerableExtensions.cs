using System.Collections;

namespace DDD.Framework.Core.Extensions
{
    public static class IEnumerableExtension
    {
        public static int Count(this IEnumerable collection)
        {
            int result = 0;

            if (collection != null)
            {
                var enumerator = collection.GetEnumerator();
                while (enumerator.MoveNext()) result = result + 1;
            }

            return result;
        }
    }
}
