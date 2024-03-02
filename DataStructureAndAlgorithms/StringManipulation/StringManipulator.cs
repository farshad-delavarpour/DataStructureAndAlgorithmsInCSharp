using System.Text;

namespace DataStructureAndAlgorithms.StringManipulation;

public class StringManipulator
{
    public static int GetVowelsCount(string str)
    {
        char[] vowels = new char[] { 'a', 'e', 'o', 'u', 'i' };
        int counter = 0;
        foreach (char @char in str.ToLower())
        {
            if (vowels.Contains(@char))
                counter++;
        }

        return counter;
    }

    public static string Reverse(string str)
    {
        Stack<char> stack = new();
        foreach (char @char in str)
            stack.Push(@char);
        string result = "";
        while (stack.Any())
        {
            result += stack.Pop();
        }
        return result;
    }

    public static string ReverseWords(string str)
    {
        Stack<string> stack = new();
        foreach (string word in str.Split())
            stack.Push(word);
        StringBuilder result = new();
        while (stack.Any())
        {
            result.Append(stack.Pop() + " ");
        }
        return result.ToString().Trim();
    }

    public static bool IsRotation(string first, string second)
    {
        if (first == null || second == null)
            return false;

        return (first + first).Contains(second) && first.Length == second.Length;
    }

    public static string RemoveDuplicate(string str)
    {
        HashSet<char> set = new();
        foreach (char @char in str)
            set.Add(@char);
        StringBuilder result = new();
        foreach (char item in set)
            result.Append(item);
        return result.ToString();
    }

    public static char GetMostRepeatedChar(string str)
    {
        if (string.IsNullOrEmpty(str))
            return default;
        Dictionary<char, int> characters = new();
        foreach (char @char in str)
        {
            if (characters.ContainsKey(@char))
                characters[@char]++;
            else
                characters.Add(@char, 1);
        }
        return characters.OrderByDescending(c => c.Value).First().Key;
    }

    public static char GetMostRepeatedCharWithOutHashTable(string str)
    {
        const int ASCII_SIZE = 256;
        int[] frequencies = new int[ASCII_SIZE];
        foreach (char @char in str)
            frequencies[@char]++;

        int max = 0;
        char result = ' ';
        for (int i = 0; i < frequencies.Length; i++)
        {
            if (frequencies[i] > max)
            {
                max = frequencies[i];
                result = (char)i;
            }

        }
        return result;
    }

    public static string CapitalizeAndRemoveSpace(string str)
    {
        string[] words = str.Trim().Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            if (string.IsNullOrWhiteSpace(words[i]))
            {
                continue;
            }
            //words[i] = words[i].Substring(0, 1).ToUpper() + words[i].Substring(1).ToLower();
            words[i] = words[i][..1].ToUpper() + words[i][1..].ToLower();
        }
        words = words.Where(w => !string.IsNullOrEmpty(w)).ToArray();
        return string.Join(' ', words);
    }

    public static bool IsAnagram(string str1, string str2)
    {
        if(str1.Length != str2.Length)
            return false;

        Dictionary<char, int> dictionary1 = new();
        Dictionary<char, int> dictionary2 = new();

        foreach(char @char in str1)
        {
            if (dictionary1.ContainsKey(@char))
                dictionary1[@char]++;
            else
                dictionary1.Add(@char, 1);
        }

        foreach (char @char in str2)
        {
            if (dictionary2.ContainsKey(@char))
                dictionary2[@char]++;
            else
                dictionary2.Add(@char, 1);
        }

        foreach((char key, int value) in dictionary1)
        {
            if (!dictionary2.ContainsKey(key))
                return false;

            if (!dictionary2.TryGetValue(key, out int val) && val != value)
                return false;
        }
        return true;
    }
}