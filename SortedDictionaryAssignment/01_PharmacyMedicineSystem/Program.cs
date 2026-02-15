using System;
using Services;
using Domain;
using Exceptions;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ManagementService service = new ManagementService();

            while (true)
            {
                Console.WriteLine("1. Display all medicines");
                Console.WriteLine("2. Update medicine price");
                Console.WriteLine("3. Add medicine");
                Console.WriteLine("4. Exit");

                int choice = int.Parse(Console.ReadLine());

                try
                {
                    switch (choice)
                    {
                        case 1:
                            var all = service.GetAll();
                            foreach (Medicine m in all)
                            {
                                Console.WriteLine($"Details: {m.Id} {m.Name} {m.Price} {m.ExpiryYear}");
                            }
                            break;

                        case 2:
                            Console.WriteLine("Enter ExpiryYear:");
                            int year = int.Parse(Console.ReadLine());

                            Console.WriteLine("Enter Medicine ID:");
                            string id = Console.ReadLine();

                            Console.WriteLine("Enter New Price:");
                            int price = int.Parse(Console.ReadLine());

                            service.UpdateEntity(year, id, price);
                            Console.WriteLine("Price Updated");
                            break;

                        case 3:
                            Console.WriteLine("Enter: Id Name Price ExpiryYear");
                            string[] input = Console.ReadLine().Split();

                            Medicine med = new Medicine
                            {
                                Id = input[0],
                                Name = input[1],
                                Price = int.Parse(input[2]),
                                ExpiryYear = int.Parse(input[3])
                            };

                            service.AddEntity(med.ExpiryYear, med);
                            Console.WriteLine("Medicine Added");
                            break;

                        case 4:
                            Console.WriteLine("Thank You");
                            return;

                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
