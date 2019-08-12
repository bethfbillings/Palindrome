using System; 
namespace Palindrome.Client
{
    class UserInput
    {
        String UserInput {get; set;}; 

        public void getUserInput()
        {
          System.Console.WriteLine("Please enter a word or sentence: ");
          userInput = Console.ReadLine(); 
        }

        public bool IsPalindrome()
        {
          char[] forward = userInput.ToCharArray(); 
          char[] backwards = new char[forward.Length]; 
          forward.CopyTo(backwards, 0);
          Array.Reverse(backwards);
          if (forward == backwards) 
          {
            return true;
          } else
          {
            return false; 
          }
        }

        public void Check()
        {
          getUserInput();
          if (IsPalindrome())
          {
            System.Console.WriteLine("\"" + userInput + "\" is a palindrome!");
          } else
          {
            System.Console.WriteLine("\"" + userInput + "\" is NOT a palindrome!");

          }
        }
    }
}