using System.Collections;

namespace DataStructureAndAlgorithms.Queue
{
    public static class Queue
    {

        public static Queue<int> Reverse(this Queue<int> queue)
        {
            Stack<int> stack = new();

            while (queue.Any())
            {
                stack.Push(queue.Dequeue());
            }

            while (stack.Any())
            {
                queue.Enqueue(stack.Pop());
            }

            return queue;
        }
    }
}