namespace DataStructureAndAlgorithms.DoublyLinkedList;
public class DoublyLinkedList<T>
{
    public DoublyLinkedListNode<T> First { get; set; }
    public DoublyLinkedListNode<T> Last { get; set; }
    public int Size { get; private set; }

    public void AddFirst(T value)
    {
        DoublyLinkedListNode<T> newNode = new(value);
        if (IsEmpty())
        {
            First = Last = newNode;
        }
        else
        {
            First.Previous = newNode;
            newNode.Next = First;
            First = newNode;
        }
        Size++;
    }

    public void AddLast(T value)
    {
        DoublyLinkedListNode<T> newNode = new(value);
        if (IsEmpty())
        {
            First = Last = newNode;
        }
        else
        {
            Last.Next = newNode;
            newNode.Previous = Last;
            Last = newNode;
        }
        Size++;
    }

    // 1, 2, 3, 4, 5
    public List<T> GetRange(int start, int end)
    {
        if (end <= start)
            throw new ArgumentOutOfRangeException();

        if (end > Size)
            throw new IndexOutOfRangeException();

        List<T> result = new();
        int counter = 0;
        DoublyLinkedListNode<T> target = First;

        while (counter != start)
        {
            target = target.Next;
            counter++;
        }

        for (int i = start; i < end; i++)
        {
            result.Add(target.Value);
            target = target.Next;
        }
        return result;
    }

    public bool IsEmpty() => Size == 0;
}

public class DoublyLinkedListNode<T>
{
    public DoublyLinkedListNode<T> Previous { get; set; }
    public DoublyLinkedListNode<T> Next { get; set; }
    public T Value { get; set; }

    public DoublyLinkedListNode(T value)
    {
        Value = value;
    }
}
