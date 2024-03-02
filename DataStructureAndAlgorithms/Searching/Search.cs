using System.Net.Http.Headers;

namespace DataStructureAndAlgorithms.Searching;

public class Search
{
    public static int LinearSearch(int target, IEnumerable<int> numbers)
    {
        int index = 0;
        foreach (int num in numbers)
        {
            if (num == target)
                return index;
            index++;
        }
        return -1;
    }

    public static int BinarySearch(int target, int[] numbers)
    {
        Sorting.Sorting.MergeSort(numbers);

        return Search(0, numbers.Length - 1);

        int Search(int start, int end)
        {
            int middle = (end + start) / 2;

            if (target == numbers[middle])
                return middle;
            if (middle == end || middle == start)
                return -1;
            return target < numbers[middle] ? Search(start, middle - 1) : Search(middle + 1, end);
        }

    }

    public static int BinarySearchIterative(int target, int[] numbers)
    {
        Sorting.Sorting.MergeSort(numbers);

        int left = 0, right = numbers.Length - 1;

        while (left <= right)
        {
            int middle = (left + right) / 2;
            if (numbers[middle] == target)
                return middle;
            if (target < numbers[middle])
                right = middle - 1;
            else
                left = middle + 1;
        }
        return -1;
    }

    public static int TernarySearch(int target, int[] numbers)
    {
        Sorting.Sorting.MergeSort(numbers);

        return Search(0, numbers.Length - 1);

        int Search(int start, int end)
        {
            if (start > end)
                return -1;
            int separate = (end - start) / 3;
            int middle1 = start + separate;
            int middle2 = end - separate;

            if (target == numbers[middle1])
                return middle1;

            if (target == numbers[middle2])
                return middle2;

            if (target < numbers[middle1])
                return Search(start, middle1 - 1);

            if (target > numbers[middle1] && target < numbers[middle2])
                return Search(middle1 + 1, middle2 - 1);

            else
                return Search(middle2 + 1, end);
        }

    }
}