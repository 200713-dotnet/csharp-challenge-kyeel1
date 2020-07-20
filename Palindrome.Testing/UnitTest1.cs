using System;
using Xunit;

namespace Palindrome.Testing
{
    public class UnitTest1
    {
        [Fact]
        public void TestSimple()
        {
            var palindrome = "tacocat";
            var index = 0;
            var lastIndex = palindrome.Length;
            var PC = new PalindromeChecker();

            var check = PC.Check(palindrome,index,lastIndex);

            Assert.isTrue(check);
        }
        [Fact]
        public void TestFailure()
        {
            var palindrome = "tacoeecat";
            var index = 0;
            var lastIndex = palindrome.Length;
            var PC = new PalindromeChecker();

            var check = PC.Check(palindrome,index,lastIndex);

            Assert.isTrue(check);
        }
        [Fact]
        public void TestEven()
        {
            var palindrome = "anna";
            var index = 0;
            var lastIndex = palindrome.Length;
            var PC = new PalindromeChecker();

            var check = PC.Check(palindrome,index,lastIndex);

            Assert.isTrue(check);
        }
        [Fact]
        public void TestSymbol()
        {
            var palindrome = "^anna^";
            var index = 0;
            var lastIndex = palindrome.Length;
            var PC = new PalindromeChecker();

            var check = PC.Check(palindrome,index,lastIndex);

            Assert.isTrue(check);
        }
        [Fact]
        public void TestNumber()
        {
            var palindrome = "1331";
            var index = 0;
            var lastIndex = palindrome.Length;
            var PC = new PalindromeChecker();

            var check = PC.Check(palindrome,index,lastIndex);

            Assert.isTrue(check);
        }
    }
}
