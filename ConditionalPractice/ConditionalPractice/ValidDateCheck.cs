using System;

namespace ConditionalPractice;

public class ValidDateCheck
{
    public static void Run()
    {
        Console.WriteLine("Enter a date to check if it is valid or not!");
        Console.Write("Enter day: ");
        int day = int.Parse(Console.ReadLine());
        if(day<0 || day > 31)
        {
            Console.WriteLine("Day must be between 1 and 31!");
            return;
            
        }

        Console.Write("Enter month: ");
        int month = int.Parse(Console.ReadLine());
        if(month<0 || month > 12)
        {
            Console.WriteLine("Month must be between 1 and 12!");
            return;
        }

        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine());
        if (year <= 0)
        {
            Console.WriteLine("Year can't be less than 0!");
            return;
        }

        // first check year is leap or not
        bool leap_year = false;

        if(year%400==0 || (year % 4 == 0) && (year % 100 != 0))
        {
            leap_year =true;
        }

        if (leap_year)
        {
            if (month == 1 && day<=31)
            {
               Console.WriteLine("Valid Date"); 
            }
            if(month==2 && day <= 29)
            {
                Console.WriteLine("Valid Date");
            }
            if (month == 3 && day<=31)
            {
               Console.WriteLine("Valid Date"); 
            }
            if(month==4 && day <= 30)
            {
                Console.WriteLine("Valid Date");
            }
            if (month == 5 && day<=31)
            {
               Console.WriteLine("Valid Date"); 
            }
            if(month==6 && day <= 30)
            {
                Console.WriteLine("Valid Date");
            }
            if (month == 7 && day<=31)
            {
               Console.WriteLine("Valid Date"); 
            }
            if(month==8 && day <= 31)
            {
                Console.WriteLine("Valid Date");
            }
            if (month == 9 && day<=30)
            {
               Console.WriteLine("Valid Date"); 
            }
            if(month==10 && day <= 31)
            {
                Console.WriteLine("Valid Date");
            }
            if (month == 11 && day<=30)
            {
               Console.WriteLine("Valid Date"); 
            }
            if(month==12 && day <= 31)
            {
                Console.WriteLine("Valid Date");
            }

        }
        else
        {
            if (month == 1 && day<=31)
            {
               Console.WriteLine("Valid Date"); 
            }
            if(month==2 && day <= 28)
            {
                Console.WriteLine("Valid Date");
            }
            if (month == 3 && day<=31)
            {
               Console.WriteLine("Valid Date"); 
            }
            if(month==4 && day <= 30)
            {
                Console.WriteLine("Valid Date");
            }
            if (month == 5 && day<=31)
            {
               Console.WriteLine("Valid Date"); 
            }
            if(month==6 && day <= 30)
            {
                Console.WriteLine("Valid Date");
            }
            if (month == 7 && day<=31)
            {
               Console.WriteLine("Valid Date"); 
            }
            if(month==8 && day <= 31)
            {
                Console.WriteLine("Valid Date");
            }
            if (month == 9 && day<=30)
            {
               Console.WriteLine("Valid Date"); 
            }
            if(month==10 && day <= 31)
            {
                Console.WriteLine("Valid Date");
            }
            if (month == 11 && day<=30)
            {
               Console.WriteLine("Valid Date"); 
            }
            if(month==12 && day <= 31)
            {
                Console.WriteLine("Valid Date");
            }
        } 


    }
}
