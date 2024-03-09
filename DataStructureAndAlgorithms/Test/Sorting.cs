using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Channels;

namespace DataStructureAndAlgorithms.Sorting
{
    internal static class Sorting
    {
        internal static int[] BubbleSort(this int[] numbers)
        {
            int length = numbers.Length;
            bool isSorted;
            for (int i = 0; i < length; i++)
            {
                isSorted = true;
                for (int j = 1; j < length - i - 1; j++)
                {
                    if (numbers[j - 1] > numbers[j])
                    {
                        (numbers[j - 1], numbers[j]) = (numbers[j], numbers[j - 1]);
                        isSorted = false;
                    }
                }
                if (isSorted)
                    break;
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

        internal static void MergeSort(this int[] list)
        {
            if (list.Length < 2)
                return;

            int middle = list.Length / 2;

            int[] left = new int[middle];
            for (int i = 0; i < middle; i++)
            {
                left[i] = list[i];
            }

            int[] right = new int[list.Length - middle];
            for (int i = middle; i < list.Length; i++)
            {
                right[i - middle] = list[i];
            }

            MergeSort(left);
            MergeSort(right);

            Merge(left, right, list);

            static void Merge(int[] left, int[] right, int[] list)
            {
                int i = 0, j = 0, k = 0;

                while (i < left.Length && j < right.Length)
                {
                    if (left[i] <= right[j])
                        list[k++] = left[i++];
                    else
                        list[k++] = right[j++];
                }

                while (i < left.Length)
                {
                    list[k++] = left[i++];
                }

                while (j < right.Length)
                {
                    list[k++] = right[j++];
                }
            }
        }

        internal static void QuickSort(int[] list, int start, int end)
        {
            if (start >= end)
                return;
            int boundry = Partition(list, start, end);
            QuickSort(list, start, boundry - 1);
            QuickSort(list, boundry + 1, end);

            static int Partition(int[] list, int start, int end)
            {
                int pivot = list[end];
                int boundry = start - 1;
                for (int i = start; i <= end; i++)
                {
                    if (list[i] <= pivot)
                    {
                        boundry++;
                        (list[boundry], list[i]) = (list[i], list[boundry]);
                    }
                }
                return boundry;
            }
        }

        internal static void CountSorting(int[] numbers)
        {
            int[] counter = new int[numbers.Max() + 1];
            foreach (int number in numbers)
                counter[number]++;

            int index = 0;
            for (int i = 0; i < counter.Length; i++)
            {
                if (counter[i] > 0)
                {
                    for (int j = 0; j < counter[i]; j++)
                        numbers[index++] = i;
                }
            }
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
}