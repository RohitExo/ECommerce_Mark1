namespace ECommerce_Mark1.Business.Core
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<TResult> ReturnAsEnumberable<TResult>(this TResult value)
        {
            yield return value;
        }

        public static string Join(this IEnumerable<string> list, string delimiter = ", ")
        {
            return list?.ToList() == null ? null : string.Join(delimiter, list);
        }
    }
}
