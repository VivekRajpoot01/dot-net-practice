using System;

namespace ConditionalPractice;

public class AdmissionEligibility
{
    public static void Run()
    {
        Console.WriteLine("Enter marks of Math, Physics and Chemistry to check Admission Eligibility");
        Console.Write("Enter Math Marks: ");
        int math = int.Parse(Console.ReadLine());
        Console.Write("\nEnter Physics Marks: ");
        int phy = int.Parse(Console.ReadLine());
        Console.Write("\nEnter Chemistry Marks: ");
        int chem = int.Parse(Console.ReadLine());

        bool eligible = false;

        if (math >= 65 &&
        phy >= 55 &&
        chem >= 50 &&
        ((math + phy + chem >= 180) ||(math+phy >= 140)))
        {
            eligible = true;
        }
       

        if (eligible)
        {
            Console.WriteLine("You are eligible for Admission!");
        }
        else
        {
            Console.WriteLine("You are not eligible for the Admission!");
        }
    }
}
