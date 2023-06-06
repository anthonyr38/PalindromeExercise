using PalindromeExercise;
using System;
using System.Net.WebSockets;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("civic", true)]
        [InlineData("crown", false)]
        [InlineData("tacocat", true)]
        [InlineData("racecar", true)]
        [InlineData("random", false)]

        public void PalindromeTest(string pal1, bool expected)
        {
            //Arange
            var wordSmith = new WordSmith();
            //Act
            var actual = wordSmith.IsAPalindrome(pal1);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
