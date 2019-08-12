using System; 
namespace Palindrome.Client
{
    class UserInput
    {
        string userInput; 

        public void getUserInput()
        {
          System.Console.WriteLine("Please enter a word or sentence: ");
          userInput = Console.ReadLine(); 
        }
    }
}