namespace System.Collections.Generic
{
    public static class Randomizer
    {
        public static Randomizer<TItem> ToRandomized<TItem>(this IEnumerable<TItem> items)
        {
            return new Randomizer<TItem>(items);
        }
    }
}
