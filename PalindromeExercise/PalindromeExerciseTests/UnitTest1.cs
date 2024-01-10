using System;
using System.Security.Cryptography.X509Certificates;
using Xunit;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("buttmonkey", false)]
        [InlineData("civic", true)]
        [InlineData("arbok", false)]
        [InlineData("kayak", true)]
        [InlineData("ekans", false)]
        [InlineData("deified", true)]
        [InlineData("deed", true)]
        [InlineData("dad", true)]
        [InlineData("grandma", false)]
        [InlineData("grandpa", false)]

        public void IsAPalindrome(string myWord, bool expected)
        {
            // Arrange
            var ws = new WordSmith();

            // Actual
            var actual = ws.IsAPalindrome(myWord);

            // Assert
            Assert.Equal(expected, actual);
        }
    }


}
