using System;

namespace EmployeeAccessSalarySystem;

public class Employee
{
    public static void Run()
    {
        Console.WriteLine("Employee Access and Salary Processing System");
        Console.WriteLine("---------------------------------");

        Console.Write("Enter employee ID: ");
        int empId = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nEnter employee name: ");
        string name = Console.ReadLine();

        Console.WriteLine("\nEnter age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        if (age < 21)
        {
            Console.WriteLine("Employee is not eligible to work.");
            return;
        }

        Console.Write("Choose Department (Use 1, 4 or 7): \n1.IT \n4.HR \n7.Finance\n");

        int department = Convert.ToInt32(Console.ReadLine());
        

        double allowance=0;
        string role = "";
        string depart = "";
        switch (department)
        {
            case 1:
                
                Console.Write("Choose Role (Use 2 or 3): \n2.Developer \n3.Tester\n");
                int _role = Convert.ToInt32(Console.ReadLine());
                depart = "IT";
                switch (_role)
                {
                    case 2:
                        allowance = 0.30;
                        role = "Developer";
                        break;
                    case 3:
                        allowance = 0.25;
                        role = "Tester";
                        break;
                }
                           
                break;                

                

            case 4:
                
                Console.Write("Choose Role (Use 5 or 6): \n5.Recruitor \n6.Payroll\n");
                int role1 = Convert.ToInt32(Console.ReadLine());
                depart = "HR";
                

                switch (role1)
                {
                    case 5:
                        allowance = 0.20;
                        role = "Recruitor";
                        break;
                    case 6:
                        allowance = 0.22;
                        role = "Payroll";
                        break;
                }
                           
                break;

            case 7:
                
                Console.Write("Choose Role (Use 8 or 9): \n8.Accountant \n9.Auditor\n");
                int role2 = Convert.ToInt32(Console.ReadLine());
                depart = "Finance";
                

                switch (role2)
                {
                    case 8:
                        allowance = 0.28;
                        role = "Accountant";
                        break;
                    case 9:
                        allowance = 0.26;
                        role = "Auditor";
                        break;
                }
                           
                break; 

            default:
                Console.WriteLine("Invalid Input");
                break;           
        }
        
        Console.WriteLine("Enter basic salary: ");
        double basicSalary = Convert.ToDouble(Console.ReadLine());

        // calculate final salary
        double finalSalary = basicSalary + (basicSalary*allowance);

        // check access level

        string accessLevel = "";

        if (finalSalary >= 60000 && depart == "IT")
        {
            accessLevel = "Admin Access";
        }else if(finalSalary>=60000 && depart != "IT")
        {
            accessLevel = "Manager Access";
        }
        else
        {
            accessLevel = "Employeee Access";
        }



        ///OUTPUT

        Console.WriteLine("\n------------------OUTPUT----------------------------------\n");     
        Console.WriteLine($"Employee ID is : {empId}");
        Console.WriteLine($"Employee Name is : {name}");
        Console.WriteLine($"Employee Department is : {depart}");
        Console.WriteLine($"Employee Role is : {role}");
        Console.WriteLine($"Employee Basic Salary is : {basicSalary}");
        Console.WriteLine($"Employee Final Salary is : {finalSalary}");
        Console.WriteLine($"Employee Access Level is : {accessLevel}");

         
        




    }
}
