public static class EnumerableExtensions
{
    public static IEnumerable<T> WhereNotEmpty<T>(this IEnumerable<T> source)
    {
        return source != null ? source.Where(item => item != null) : Enumerable.Empty<T>();
    }
}
