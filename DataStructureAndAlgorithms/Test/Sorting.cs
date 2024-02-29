namespace DataStructureAndAlgorithms.Sorting
{
    internal static class Sorting
    {
        internal static int[] BubbleSort(this int[] numbers)
        {
            int length = numbers.Length;
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < length - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        (numbers[j], numbers[j + 1]) = (numbers[j + 1], numbers[j]);
                    }
                }
            }
            return numbers;
        }

        internal static int[] InsertionSort(this int[] numbers)
        {
            int length = numbers.Length;
            for (int i = 1; i < length; i++)
            {
                int current = numbers[i];
                int j = i - 1;
                while (j >= 0 && numbers[j] > current)
                {
                    numbers[j + 1] = numbers[j];
                    j--;
                }
                numbers[j + 1] = current;
            }
            return numbers;
        }

        internal static int[] SelectionSort(this int[] list)
        {
            int length = list.Length;
            for (int i = 0; i < length; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < length; j++)
                {
                    if (list[j] < list[minIndex])
                        minIndex = j;
                }
                (list[i], list[minIndex]) = (list[minIndex], list[i]);
            }
            return list;
        }

        internal static int[] GetTwoSum(int[] numbers, int target)
        {
            Dictionary<int, int> numDic = new();
            for (int i = 0; i < numbers.Length; i++)
            {
                int subtraction = target - numbers[i];
                if (numDic.ContainsKey(subtraction))
                    return new int[] { numbers[i], subtraction };

                numDic[numbers[i]] = i;
            }

            return Array.Empty<int>();
        }
    }

    public class BrowserHistory
    {
        private LinkedList<string> _history = new();

        public BrowserHistory(string homepage)
        {
            _history.AddFirst(homepage);
        }

        public void Visit(string url)
        {
            LinkedListNode<string> target;

        }

    }



}