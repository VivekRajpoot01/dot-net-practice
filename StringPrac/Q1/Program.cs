using System;

public class Program
{
    public static void Main()
    {
        Dictionary<string,int> dict = new Dictionary<string, int>();
        string inp = Console.ReadLine();

        string[] words = inp.Split(' ', StringSplitOptions.RemoveEmptyEntries);


        foreach(string word in words)
        {
            char[] arr = word.ToCharArray();
            string str = "";
            foreach(char ch in arr)
            {
                
                if (!char.IsPunctuation(ch))
                {
                    str += ch;
                }
            }
            if (dict.ContainsKey(str))
            {
                dict[str] += 1;
            }
            else
            {
                dict[str] = 1;
            }
        }

        foreach(var kv in dict)
        {
            Console.WriteLine($"{kv.Key}: {kv.Value}");
        }

    }
}