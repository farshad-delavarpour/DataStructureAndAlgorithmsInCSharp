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
    }
}
