using System;

class Program
{
    public static void Main()
    {
        // Input from user
        Console.WriteLine("Enter the sentence");
        string sentence = Console.ReadLine();

        string[] words = sentence.Split(" ");

        int length = words.Length;
        Console.WriteLine("Word Count: "+length);

        string newStr = "";

        
        if (length % 2 == 0)
        {
            for(int i=length-1; i>=0; i--)
            {
                newStr += words[i]+ " ";
            }

            Console.WriteLine(newStr.Trim());
        }
        else
        {
            for(int i=0; i<length; i++)
            {
                char[] cArray =  words[i].ToCharArray();
                Array.Reverse(cArray);
                newStr += new string(cArray)+" "; 
            }

            Console.WriteLine(newStr.Trim());
            
        }
    }
}