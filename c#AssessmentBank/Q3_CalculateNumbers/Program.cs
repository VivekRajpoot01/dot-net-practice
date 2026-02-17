public class Program
{
    public static List<int> nums = new List<int>();
    

    public static void AddNumbers(int numbers)
    {
        nums.Add(numbers);
    }

    public static double GetGPAScored()
    {
        if (nums.Count == 0)
        {
            return -1;
        }
        int sum = 0;
        foreach(int num in nums)
        {
            sum += num*3;
        }
        return sum/(nums.Count*3);
    }

    public static char GetGradeScored(double gpa)
    {
        if(gpa<5 || gpa > 10)
        {
            Console.WriteLine("Invalid gpa");
            return '\0';
        }
        if(gpa == 10)
        {
            return 'S';
        }else if(gpa>=9 && gpa < 10)
        {
            return 'A';
        }else if(gpa>=8 && gpa < 9)
        {
            return 'B';
        }else if(gpa>=7 && gpa < 8)
        {
            return 'C';
        }else if(gpa>=6 && gpa < 7)
        {
            return 'D';
        }
        return 'E';

        
    }
    public static void Main()
    {
        
    }
}