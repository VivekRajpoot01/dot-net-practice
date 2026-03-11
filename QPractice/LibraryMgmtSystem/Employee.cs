using System;

namespace LibraryMgmtSystem;

public class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }

    public Employee(int id, string name, int salary)
    {
        ID = id;
        Name = name;
        Salary = salary;
    }
}

public class Program
{
    public static void Main()
    {
        Employee empObj = new Employee(1, "Vivek", 40000);
        Console.WriteLine($"Id : {empObj.ID}");
        Console.WriteLine($"Name : {empObj.Name}");
        Console.WriteLine($"Salary : {empObj.Salary}");
    }
}
