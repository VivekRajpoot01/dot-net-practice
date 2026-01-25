using System;
using System.Collections.Generic;
using System.Linq; // Hint: Might be useful for deleting, but looping works too

public class Case
{
    public int CaseNo { get; set; }
    public string CaseCode { get; set; }
    public string CaseContent { get; set; }
    public DateTime Date { get; set; }
}

public class Program
{
    public static List<Case> CaseFile = new List<Case>();

    public static void Main(string[] args)
    {
        Console.WriteLine("1. Add to the list\n2. Delete from the list");

        Console.WriteLine("Enter your choice");
        int choice = int.Parse(Console.ReadLine());

        Case caseObj = new Case();

        if (choice == 1)
        {
            Console.WriteLine("Enter the case no");
            caseObj.CaseNo = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the case code");
            caseObj.CaseCode = Console.ReadLine();

            Console.WriteLine("Enter the case content");
            caseObj.CaseContent = Console.ReadLine();

            Console.WriteLine("Enter the date:");
            caseObj.Date = DateTime.Parse(Console.ReadLine());

            if (AddToList(caseObj))
            {
                Console.WriteLine("Added successfully");
            } 
        }else if (choice == 2)
        {
            Console.WriteLine("Enter the case no");
            int caseNo = int.Parse(Console.ReadLine());

            if (DeleteFromList(caseNo))
            {
                Console.WriteLine("Deleted successfully");
            }
            else
            {
                Console.WriteLine("Deleting failed");
            } 
        }
    }

    public static bool AddToList(Case caseObj)
    {
        CaseFile.Add(caseObj);
        return true;
        
    }

    public static bool DeleteFromList(int caseNo)
    {
        Case caseToRemove = CaseFile.Find(c => c.CaseNo == caseNo);

        if(caseToRemove != null)
        {
            CaseFile.Remove(caseToRemove);
            return true;
        }
        
        return false;
        
    }
}