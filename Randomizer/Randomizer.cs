using System.Linq;

namespace System.Collections.Generic
{
    public class Randomizer<TItem> : IEnumerable<TItem>
    {
        #region Implementation of IEnumerable

        public TItem[] Items { get; set; }

        public Randomizer(IEnumerable<TItem> items)
        {
            Items = items.ToArray();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<TItem> GetEnumerator()
        {
            return new RandomItemEnumerator<TItem>(Items);
        }

        #endregion
    }
}

