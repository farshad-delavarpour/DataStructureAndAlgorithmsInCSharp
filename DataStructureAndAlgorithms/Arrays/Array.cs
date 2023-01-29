namespace DataStructureAndAlgorithms.Arrays
{
    public class Array
    {
        private int[] _items;
        private int _count;

        public Array(int length)
        {
            _items = new int[length];
        }

        public void Print()
        {
            for (var i = 0; i < _count; i++)
            {
                System.Console.WriteLine(_items[i]);
            }
        }

        public void Insert(int item)
        {
            ResizeIfRequired();

            _items[_count] = (item);

            _count++;
        }

        public void RemoveAt(int index)
        {
            if (index >= _count)
                throw new IndexOutOfRangeException();

            for (int i = index; i < _count; i++)
            {
                _items[i] = _items[i + 1];
            }

            _items[_count - 1] = 0;
            _count--;
        }

        public int IndexOf(int item)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_items[i] == item)
                    return i;
            }

            return -1;
        }

        public int Max()
        {
            if (_count == 0)
                return -1;

            var max = 0;

            foreach (var item in _items)
            {
                if (item > max)
                    max = item;
            }
            return max;
        }

        public Array Intersect(Array other)
        {
            var commonValues = new Array(_count);

            foreach (var item in _items)
            {
                if (other.IndexOf(item) >= 0)
                    commonValues.Insert(item);
            }

            return commonValues;
        }

        public void Reverse()
        {
            var reverseArray = new int[_count];

            for (int i = 1; i <= _count; i++)
            {
                reverseArray[_count - i] = _items[i - 1];
            }

            _items = reverseArray;
        }

        public void InsertAt(int item, int index)
        {
            if (index >= _count)
                throw new ArgumentOutOfRangeException();

            ResizeIfRequired();

            for (int i = _count - 1; i >= index; i--)
                _items[i + 1] = _items[i];

            _items[index] = item;
            _count++;
        }

        private void ResizeIfRequired()
        {
            if (_items?.Length == _count)
            {
                var newArray = new int[_count * 2];

                for (var i = 0; i < _count; i++)
                {
                    newArray[i] = _items[i];
                }
                _items = newArray;
            }
        }
    }
}