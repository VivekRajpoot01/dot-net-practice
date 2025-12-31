// See https://aka.ms/new-console-template for more information
using LPU_BL;
using LPU_Entity;

namespace LPU_UI
{
    class Program
    {
        static void Menu()
        {
            Console.WriteLine("Student Management System  ");
            Console.WriteLine("================================");
            Console.WriteLine("1. Search Student By ID ");
            Console.WriteLine("2. Show All Students");
            Console.WriteLine("3. Add Student Details");
            Console.WriteLine("4. Update Student Details");
            Console.WriteLine("5. Drop Student Details");
            Console.WriteLine("6. Exit");
        }
        static void Main(string[] args)
        {
            StudentBL sblObj = null;
            sblObj = new StudentBL();

            do
            {
                Menu();
                int choice = 0;
                Console.Write("Enter your choice : ");
                choice = Int32.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: //Search Student By ID
                        {
                            int id = 0;
                            Console.Write("Enter Student ID to search : ");
                            id = Int32.Parse(Console.ReadLine());

                            Student sObj = sblObj.SearchStudentByID(id);

                            if (sObj != null)
                            {
                                Console.WriteLine("ID\t| Name\t| Course\t| Address");
                                Console.WriteLine("------------------------------------------------");
                                Console.WriteLine($"{sObj.StudentID}\t| {sObj.Name}\t| {sObj.Course}\t| {sObj.Address}");
                            }
                            break;
                        }

                    case 2: //Show All Students
                        {
                            sblObj.Sear

                            break;
                        }

                    case 3: //Add Students
                        {

                            break;
                        }

                    case 4: //Search Student By ID
                        {

                            break;
                        }

                    case 5: //Search Student By ID
                        {

                            break;
                        }

                    case 6: //Exit
                        {

                            break;
                        }

                    default:
                        break;

                }

            } while (true);
        }
    }
}