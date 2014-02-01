namespace System.Collections.Generic
{
    public static class Randomizer
    {
        public static IEnumerable<TItem> ToRandomized<TItem>(this IEnumerable<TItem> items)
        {
            return new Randomizer<TItem>(items);
        }
    }
}
