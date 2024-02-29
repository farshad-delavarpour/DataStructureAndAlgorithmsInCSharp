using System.Runtime.CompilerServices;

namespace DataStructureAndAlgorithms.Queue;

public class ArrayQueue<T>
{
    private T[] _items;
    private int _size;

    public ArrayQueue(int size)
    {
        _items = new T[size];
        _size = 0;
    }

    public void Enqueue(T item)
    {
        if (IsFull())
            throw new OverflowException();
        _items[_size++] = item;
    }

    public T Dequeue()
    {
        T item = _items[0];
        for (int i = 0; i < _size - 1; i++)
        {
            _items[i] = _items[i + 1];
        }
        _items[--_size] = default;
        return item;
    }

    public T Peek()
    {
        return _items[0];
    }

    public bool IsFull() => _items.Length == _size;
    public bool IsEmpty() => _items.Length == 0;
}

public class StackQueue
{
    private Stack<int> _stack = new();

    public void Enqueue(int item)
    {
        _stack.Push(item);
    }

}