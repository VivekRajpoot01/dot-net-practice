using System;

namespace ConditionalPractice;

public class VowelOrConsonant
{
    public static void Run()
    {
        Console.Write("Enter a character to check vowel or consonant: ");
        char ch = char.Parse(Console.ReadLine());

        switch (ch)
        {
            case 'a':
                Console.WriteLine("Character is Vowel");
                break;
            case 'e':
                Console.WriteLine("Character is Vowel");
                break;
            case 'i':
                Console.WriteLine("Character is Vowel");
                break;
            case 'o':
                Console.WriteLine("Character is Vowel");
                break;
            case 'u':
                Console.WriteLine("Character is Vowel");
                break;
            default:
                Console.WriteLine("Character is Consonant");
                break;                    


        }

    }
}
