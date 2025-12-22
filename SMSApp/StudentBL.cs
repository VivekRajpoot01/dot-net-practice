using System;

namespace SMSApp;

public class StudentBL
{
    Student sObj = null;

    public StudentBL()
    {
        sObj = new Student();
    }

    public void AcceptStudentDetails()
    {
        try
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Student Management System ");
            Console.WriteLine("----------------------------------");

            System.Console.WriteLine("Enter your RollNo: ");
            sObj.RollNo = Int32.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter your Name: ");
            sObj.Name = Console.ReadLine();

            System.Console.WriteLine("Enter your Address: ");
            sObj.Address = Console.ReadLine();

            System.Console.WriteLine("Enter your Physics Marks: ");
            sObj.Phy = Int32.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter your Chemistry Marks: ");
            sObj.Chem = Int32.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter your Maths Marks: ");
            sObj.Maths = Int32.Parse(Console.ReadLine());
        }
        catch (InvalidMarksException e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(e.Message);
        }
        catch (Exception e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(e.Message);
        }



    }


    public int calcTotal()
    {
        sObj.Total = sObj.Phy + sObj.Chem + sObj.Maths;
        return sObj.Total;
    }

    public float calcAvg()
    {
        sObj.Perc = sObj.Total / 3;
        return sObj.Perc;
    }

    public void calcResult(out int myTotal, out float myPerc)
    {
        myTotal = sObj.Phy + sObj.Chem + sObj.Maths;
        myPerc = myTotal / 3;
    }
}
