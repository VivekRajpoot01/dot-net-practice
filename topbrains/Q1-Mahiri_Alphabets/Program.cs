// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        
        string firstWord = Console.ReadLine();
        string secondWord = Console.ReadLine();

        
        HashSet<char> secondWordChars = new HashSet<char>();
        foreach (char c in secondWord.ToLower())
        {
            secondWordChars.Add(c);
        }

        
        StringBuilder filtered = new StringBuilder();
        foreach (char c in firstWord)
        {
            char lowerChar = char.ToLower(c);

            if (IsVowel(lowerChar))
            {
                
                filtered.Append(c);
            }
            else
            {
                
                if (!secondWordChars.Contains(lowerChar))
                {
                    filtered.Append(c);
                }
            }
        }

        
        StringBuilder result = new StringBuilder();
        char? previous = null;

        foreach (char c in filtered.ToString())
        {
            if (previous == null || char.ToLower(c) != char.ToLower(previous.Value))
            {
                result.Append(c);
                previous = c;
            }
        }

        
        Console.WriteLine(result.ToString());
    }

    static bool IsVowel(char c)
    {
        return "aeiou".IndexOf(c) != -1;
    }
}