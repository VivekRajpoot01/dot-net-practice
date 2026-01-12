using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LINQConsoleApp
{
    class Program
    {
        public static void LinqToObjectDemo()
        {
            int[] numArray = { 10, 2, 12, 34, 65, 89, 45,92,56,77 };
            string[] nameArray = { "Ramesh", "Mahendra", "Harshit", "Sonam", "Alok","Riya","Pawas","Don","Badmas" };

            //foreach(var item in numArray)
            //{
            //    if (item % 2 == 0)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            // LINQ QUERY

            //var result = from data in numArray
            //             where data % 2 == 0 && data>20
            //             select data;

            Console.Write("enter name to search: ");
            string dataToSearch = Console.ReadLine();

            var result = nameArray.Where(n => n == dataToSearch);



            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        public static void LinqToObjectDemoCustomType()
        {
            List<Customer> custList = new List<Customer>()
            {
                new Customer {CustomerId = 101, Name = "Alok",City = "Pune"},
                new Customer(){CustomerId = 102, Name = "Pawas",City = "Nalanda"}, //old way
                new Customer {CustomerId = 103, Name = "Aditya",City = "Shimla"},
                new Customer {CustomerId = 104, Name = "Shlok",City = "Delhi"},
                new Customer {CustomerId = 105, Name = "Adam",City = "New York"},
                new Customer {CustomerId = 106, Name = "DJ Alok",City = "Mumbai"},
            };

            // Anonymous Object
            var data = new { OrderId = 1001, OrderDate = "12/01/2026", Amount = 14000 };

            var result = custList.Where(cust => cust.City == "Mumbai");
            var result1 = custList.Find(cust => cust.City == "Delhi");

            foreach(var item in result)
            {
                Console.WriteLine($"{item.CustomerId}\t{item.Name}\t{item.City}");
            }
        }

        public static void LambdaLookUp()
        {
            StudentRepo sRepo = new StudentRepo();
            List<Student> tempList = sRepo.GetAllStudent();
            
            //int[] numbers = { };
            var query = tempList.ToLookup(s => s.Gender == "Male");

            foreach(IGrouping<bool,Student> group in query)
            {
                Console.WriteLine("Key: {0}", group.Key);

                foreach(Student std in group)
                {
                    Console.WriteLine(std.Name);
                }
            }

            var maleFeesPaid = tempList.Where(s => s.Gender == "Male");
        }
        public static void Main()
        {
            //LinqToObjectDemo();
            //LinqToObjectDemoCustomType();
            //LambdaLookUp();

            StudentRepo sRepo = new StudentRepo();

            List<Student> tempList = sRepo.GetAllStudent();

            var total = tempList.Select(s => s.Fees).Sum();

            Console.WriteLine("Fees: {0}", total);
        }
    }
}
