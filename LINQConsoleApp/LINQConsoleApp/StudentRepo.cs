using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQConsoleApp
{
    public class StudentRepo
    {
        static List<Student> studList;

        public StudentRepo()
        {
            if (studList == null)
            {
                studList = new List<Student>()
                {
                    new Student(){RollNo=1,Name="Amit",Gender="Male",Marks=87,Fees = 15000},
                    new Student(){RollNo=2,Name="Sumit",Gender="Male",Marks=64,Fees=20000},
                    new Student(){RollNo=3,Name="Ronit",Gender="Male",Marks=79,Fees=14000},
                    new Student(){RollNo=4,Name="Jassi",Gender="Female",Marks=89,Fees=12000},
                    new Student(){RollNo=5,Name="Nancy",Gender="Female",Marks=77,Fees=10500}
                };
            }
        }

        public List<Student> GetAllStudent()
        {
            return studList;
        }
    }
}
