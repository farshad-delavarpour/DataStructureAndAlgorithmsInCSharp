using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms.Test
{
    public static class Random
    {
        public static char GetFirstNonRepeat(string str)
        {
            Dictionary<char, int> test = new();
            foreach (char @char in str)
            {
                if (test.ContainsKey(@char))
                    test[@char] += 1;
                else
                    test.Add(@char, 1);
            }

            return test.FirstOrDefault(i => i.Value == 1).Key;
        }

        public static IEnumerable<int> ReturnUnique(IEnumerable<int> list)
        {
            HashSet<int> sets = new();
            foreach (int item in list)
                sets.Add(item);
            return sets.ToArray();
        }

        public static int Fib(int n)
        {
            if (n == 1 || n == 2)
                return 1;

            return Fib(n - 1) + Fib(n - 2);
        }

        public static bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            // [1, 0, 0, 0, 1]
            int i = 0, j = 1;
            int result = 0;
            while (j < flowerbed.Length)
            {
                if (flowerbed[i] + flowerbed[j] == 0)
                {
                    flowerbed[i] = 1;
                    result++;
                    i++;
                    j++;
                }
            }

            return result == n;
        }

        public static string ReverseVowels(string s)
        {
            char[] vowels = new char[5] { 'a', 'e', 'i', 'o', 'u' };
            Stack<char> stack = new();

            for (int k = 0; k < s.Length; k++)
            {
                if (vowels.Contains(char.ToLower(s[k])))
                {
                    stack.Push(s[k]);
                }
            }

            if (!stack.Any())
                return s;

            StringBuilder result = new();

            for (int i = 0; i < s.Length; i++)
            {
                if (vowels.Contains(char.ToLower(s[i])))
                {
                    result.Append(stack.Pop());
                }
                else
                {
                    result.Append(s[i]);
                }
            }

            return result.ToString();
        }

        public static int MaxVowels(string s, int k)
        {
            char[] vowels = new char[5] { 'i', 'a', 'u', 'o', 'e' };
            int maxVowels;
            int tempCounter = 0;
            int leftIndex = 0;
            for (int i = 0; i < k; i++)
            {
                if (vowels.Contains(s[i]))
                    tempCounter++;
            }
            maxVowels = tempCounter;
            for(int i = k; i < s.Length; i++)
            {
                if (tempCounter == k)
                    return k;

                if (vowels.Contains(s[i]) && !vowels.Contains(s[leftIndex]))
                {
                    tempCounter++;
                }
                else if (vowels.Contains(s[leftIndex]) && !vowels.Contains(s[i]))
                {
                    tempCounter--;
                }
                if (tempCounter > maxVowels)
                    maxVowels = tempCounter;
                leftIndex++;
            }

            return maxVowels;
        }

        public static int LongestOnes(int[] nums, int k)
        {
            int windowStart = 0;
            int maxLength = 0;
            int maxOnesCount = 0;

            for (int windowEnd = 0; windowEnd < nums.Length; windowEnd++)
            {
                if (nums[windowEnd] == 1)
                    maxOnesCount++;

                if (windowEnd - windowStart + 1 - maxOnesCount > k) // the zeros
                {
                    if (nums[windowStart++] == 1)
                        maxOnesCount--;
                }
                maxLength = Math.Max(maxLength, windowEnd - windowStart + 1);
            }

            return maxLength;
        }

        public static int LongestSubarray(int[] nums)
        {
            int oneCounts = 0;
            int start = 0;
            int longest = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                    oneCounts++;
                if (i - start + 1 - oneCounts > 1)
                {
                    if (nums[start++] == 1)
                        oneCounts--;
                }
                longest = Math.Max(longest, i - start + 1);
            }
            return longest;
        }

        public static int LargestAltitude(int[] gain)
        {
            int highest = 0;
            int current = 0;
            foreach (int number in gain)
            {
                current += number;
                if (current > highest)
                    highest = current;
            }
            return highest;
        }

        public static int PivotIndex(int[] nums)
        {
            int[] rightSum = new int[nums.Length];
            int tempSum = 0;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                tempSum += nums[i];
                rightSum[i] = tempSum;
            }
            tempSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                tempSum += nums[i];
                if (tempSum == rightSum[i])
                    return i;
            }
            return -1;
        }

        public static string RemoveStars(string s)
        {
            Stack<char> history = new();
            foreach(char @char in s)
            {
                if(@char != '*')
                    history.Push(@char);
                else
                {
                    if(history.Any())
                        history.Pop();
                }
            }
            return new string(history.Reverse().ToArray());
        }
    }

}

public static class LeetCode
{
    public static int MaxOperations(int[] nums, int k)
    {
        Array.Sort(nums);

        int i = 0, j = nums.Length - 1;
        int count = 0;

        while (i < j)
        {
            int sum = nums[i] + nums[j];
            if (sum == k)
            {
                count++;
                i++;
                j--;
            }
            else if (sum > k)
            {
                j--;
            }
            else
            {
                i++;
            }

        }
        return count;
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public static ListNode ReverseList(ListNode head)
    {
        if (head is null)
            return head;
        ListNode previous = head;
        ListNode current = head.next;
        previous.next = null;
        while (current != null)
        {
            ListNode next = current.next;
            current.next = previous;

            previous = current;
            current = next;
        }
        return previous;
    }

    public static ListNode DeleteMiddle(ListNode head)
    {
        ListNode current = head;
        ListNode target = head;
        while (current != null && current.next != null)
        {
            target = target.next;
            current = current.next.next;
        }
        target.next = target.next.next;
        return head;
    }

    public static ListNode OddEvenList(ListNode head)
    {
        ListNode lastOdd = head;
        ListNode lastEven = head.next;
        ListNode firstEven = head.next;

        while (lastEven != null)
        {
            lastOdd.next = lastEven.next;
            lastEven.next = lastEven.next.next;
            lastOdd.next.next = firstEven;
            lastOdd = lastOdd.next;
            lastEven = lastEven.next;
        }
        return head;
    }

    // 1 -> 2 -> 3 -> 4 -> 5 -> 6
    public static int PairSum(ListNode head)
    {
        if (head == null || head.next == null) return 0;
        Stack<int> stack = new();
        ListNode slow = new(0, head);
        ListNode fast = head;

        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
            stack.Push(slow.val);
        }

        slow = slow.next;
        int result = 0;

        while (slow != null)
        {
            int sum = slow.val + stack.Pop();
            if (sum > result)
                result = sum;
            slow = slow.next;
        }

        return result;
    }
}
