// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

public class Program
{
    public static void Main()
    {
        int input = 0;

        while (input != 4)
        {
            Console.WriteLine("=========================MediSure Clinic Billing================================");
            Console.WriteLine("1. Create New Bill (Enter Patient Details)");
            Console.WriteLine("2. View Last Bill");
            Console.WriteLine("3. Clear Last Bill");
            Console.WriteLine("4. Exit");
            
            Console.Write("Enter your option: ");

            input = int.Parse(Console.ReadLine());

            if (input == 1)
            {
                PatientBill PatientBillObj = new PatientBill();
                PatientBillObj.CreateBill();
            }
            else if (input == 2)
            {
                PatientBill.PrintLastBill();
            }
            else if (input == 3)
            {
                PatientBill.ClearLastBill();
            }
            else if (input == 4)
            {
                Console.WriteLine("Thank you. Application closed normally.");
            }
        }
    }
}
