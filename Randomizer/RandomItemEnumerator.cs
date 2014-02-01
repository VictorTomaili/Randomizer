namespace System.Collections.Generic
{
    public class RandomItemEnumerator<TItem> : IEnumerator<TItem>
    {
        private readonly TItem[] _items;
        private readonly Random _random = new Random();
        private int _position;
        public void Shuffle<T>(T[] array)
        {
            var random = _random;
            for (var i = array.Length; i > 1; i--)
            {
                var j = random.Next(i);
                var tmp = array[j];
                array[j] = array[i - 1];
                array[i - 1] = tmp;
            }
        }

        public RandomItemEnumerator(TItem[] list)
        {
            _items = list.Clone() as TItem[];
            Reset();
        }

        #region Implementation of IEnumerator

        public bool MoveNext()
        {
            _position++;
            return _position < _items.Length;
        }

        public void Reset()
        {
            Shuffle(_items);
            _position = -1;
        }

        public TItem Current
        {
            get
            {
                try
                {
                    return _items[_position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
        object IEnumerator.Current
        {
            get { return Current; }
        }

        #endregion

        #region Implementation of IDisposable

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}