using DataStructureAndAlgorithms.LeetCode;

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
    }
}
