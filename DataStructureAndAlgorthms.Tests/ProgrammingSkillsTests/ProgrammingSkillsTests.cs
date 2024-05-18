using DataStructureAndAlgorithms.LeetCode;
using System.Collections.Generic;

namespace DataStructureAndAlgorthms.Tests.ProgrammingSkillsTests
{
    public class ProgrammingSkillsTests
    {
        [Theory]
        [InlineData("test", "tests", 's')]
        [InlineData("find", "fined", 'e')]
        [InlineData("sample", "ssample", 's')]
        [InlineData("", "y", 'y')]
        public void FindDifference_ShouldReturn_DiffenentCharachter(string first, string second, char diffenece)
        {
            char result = ProgrammingSkills.FindTheDifference(first, second);
            Assert.Equal(diffenece, result);
        }

        [Theory]
        [InlineData("sometext", "text", 4)]
        [InlineData("text", "1", -1)]
        [InlineData("mississippi", "issip", 4)]
        [InlineData("leetcode", "leeto", -1)]
        public void FindIndex_ShouldReturn_TheFirstIndexOfOccurance(string text, string target, int index)
        {
            int result = ProgrammingSkills.FindIndexOfFirstOccurrence(text, target);
            Assert.Equal(result, index);
        }

        [Theory]
        [InlineData("abab", true)]
        [InlineData("abcdabcdabcd", true)]
        [InlineData("ababdc", false)]
        [InlineData("a", false)]
        public void RepeatedSubstringPattern_ShouldReturn_ExpectedResult(string text, bool result)
        {
            bool hasRepeatedPattern = ProgrammingSkills.RepeatedSubstringPattern(text);
            Assert.Equal(hasRepeatedPattern, result);
        }
    }
}
