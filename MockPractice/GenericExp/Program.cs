using System;
using System.Collections;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        // Non Generic
        ArrayList arrayList = new ArrayList();
        arrayList.Add(1);
        arrayList.Add("Vivek");

        //Generic
        List<string> nameList = new List<string>();
        nameList.Add("Vivek");
        nameList.Add("Ram");
        //nameList.Add(3); //compile time error

        // for reverse the string
        string rev = ReverseString("HEllo");
        Console.WriteLine(rev);

        // to count the frequency

        Console.WriteLine("Enter string to check frequency: ");
        string str = Console.ReadLine();
        var dict = CharCount(str);

        foreach(var item in dict)
        {
            Console.WriteLine();
        }
    }

    public static string ReverseString(string str)
    {
        string rev = "";
        for(int i= str.Length-1; i>=0; i--)
        {
            rev += str[i];
        } 
        
        
        return rev;
    }

    public static Dictionary<char,int> CharCount(string str)
    {
        Dictionary<char,int> dict = new Dictionary<char, int>();

        int n = str.Length;
        for(int i=0; i<n; i++)
        {
            if (dict.ContainsKey(str[i]))
            {
                dict[str[i]] += 1;
            }
            else
            {
                dict.Add(str[i],1);
            }
        }

        return dict;
    }

    static int CountDeletions(string word1, string word2)
    {
        int deletions = 0;

        
        for (int i = 0; i < word1.Length;)
        {
            if (!word2.Contains(word1[i]))
            {
                word1 = word1.Remove(i, 1);
                deletions++;
            }
            else
            {
                i++;
            }
        }

        
        for (int i = 0; i < word2.Length;)
        {
            if (!word1.Contains(word2[i]))
            {
                word2 = word2.Remove(i, 1);
                deletions++;
            }
            else
            {
                i++;
            }
        }

        return deletions;
    }

}