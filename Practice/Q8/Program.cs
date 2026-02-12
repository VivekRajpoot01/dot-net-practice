using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

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
        // Assume Input logic is handled for you or implement standard Menu:
        // 1. Add (Read inputs -> Create Obj -> AddToList -> Print Result)
        // 2. Delete (Read ID -> DeleteFromList -> Print Result)
        Case caseObj = new Case();
        int inp = int.Parse(Console.ReadLine());

        if(inp == 1)
        {
            caseObj.CaseNo = int.Parse(Console.ReadLine());
            caseObj.CaseCode = Console.ReadLine();
            caseObj.CaseContent = Console.ReadLine();
            caseObj.Date = DateTime.Parse(Console.ReadLine());

            if (AddToList(caseObj))
            {
                Console.WriteLine("Added successfully");
            }
            else
            {
                Console.WriteLine("Adding failed");
            }
        }else if(inp == 2)
        {
            int caseNo = int.Parse(Console.ReadLine());
            if (DeleteFromList(caseNo))
            {
                Console.WriteLine("Remove Successfully");
            }
            else
            {
                Console.WriteLine("Remove Unsuccessfull");
            }
        }
    }

    public static bool AddToList(Case caseObj)
    {
        // TODO: Validate caseObj.CaseCode using Regex "^KN[3-11]{3}$"
        // TODO: If valid, Add to CaseFile and return true
        Regex reg = new Regex("^KN[0-9]{3}$");
        if (reg.IsMatch(caseObj.CaseCode))
        {
            CaseFile.Add(caseObj);
            return true;
        }

        return false; 
    }

    public static bool DeleteFromList(int caseNo)
    {
        // TODO: Remove item safely
        Case caseobj = null;
        foreach(var cs in CaseFile)
        {
            if(cs.CaseNo == caseNo)
            {
                caseobj = cs;
            }
        }

        if (caseobj != null)
        {
            CaseFile.Remove(caseobj);
            return true;
        }
        return false;
    }
}