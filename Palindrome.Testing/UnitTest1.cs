using System;
using Xunit;

namespace Palindrome.Testing
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
          UserInput input = new UserInput;
          input.setUserInput("Hello");
          bool actual = input.IsPalindrome(); 
          bool expected = false; 
          Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
          UserInput input = new UserInput;
          input.setUserInput("wow");
          bool actual = input.IsPalindrome(); 
          bool expected = true; 
          Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test3()
        {
          UserInput input = new UserInput;
          input.setUserInput("live not on evil");
          bool actual = input.IsPalindrome(); 
          bool expected = false; 
          Assert.Equal(expected, actual);
        }
    }
}
