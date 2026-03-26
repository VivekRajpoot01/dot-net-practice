using System;
using System.Collections.Generic;

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Marks { get; set; }
}

public class StudentComparer : IComparer<Student>
{
    public int Compare(Student x, Student y)
    {
        int marksCompare = y.Marks.CompareTo(x.Marks);
        if (marksCompare != 0) return marksCompare;
        return x.Age.CompareTo(y.Age);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        var students = new List<Student>();

        for (int i = 0; i < n; i++)
        {
            var parts = Console.ReadLine().Split(' ');
            students.Add(new Student
            {
                Name = parts[0],
                Age = int.Parse(parts[1]),
                Marks = int.Parse(parts[2])
            });
        }

        students.Sort(new StudentComparer());

        foreach (var s in students)
            Console.WriteLine($"{s.Name} {s.Age} {s.Marks}");
    }
}