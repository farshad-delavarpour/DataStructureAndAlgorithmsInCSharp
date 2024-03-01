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
}