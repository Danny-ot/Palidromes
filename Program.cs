using System;
using Checker.Models;

namespace Checker
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Palindrome Checker");
            Console.WriteLine();
            Console.WriteLine("Input a word to check if it is a palindrome");
            string  word = Console.ReadLine().ToLower();
            Console.WriteLine(PalindromeChecker.Check(word));
        }
        

    }
}