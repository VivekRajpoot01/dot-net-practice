using LPU_Common;
using LPU_Entity;
using LPU_Exceptions;

namespace LPU_DAL
{
    /// <summary>
    /// Student DAO class is used for CRUD operations
    /// </summary>
    public class StudentDAO: IStudentCRUD
    {
        static List<Student> StudentList = null;

        public StudentDAO()
        {
            if(StudentList == null) {
                StudentList = new List<Student>()
                {
                    new Student(){Id = 101, Name = "Vivek", Course = Student.CourseType.CSE, Address = "UP"},
                    new Student(){Id = 102, Name = "Pawas", Course = Student.CourseType.CSE, Address = "Bihar"},
                    new Student(){Id = 103, Name = "Shiva", Course = Student.CourseType.Mechanical, Address = "UP"},
                    new Student(){Id = 104, Name = "Nishant", Course = Student.CourseType.Civil, Address = "Tamil Naidu"}
                };
            }
            
        }
        public Student SearchStudentById(int rollNo)
        {
            Student myStud = null;
            if(rollNo != 0)
            {
                myStud = StudentList.Find(s => s.Id == rollNo);
                if (myStud == null)
                {
                    throw new LpuException("Student record not found");
                }
            }
            else
            {
                throw new LpuException("Error Generated");
            }
            return myStud;
        }

        public List<Student> SearchStudentByName(string name)
        {
            List<Student> data = StudentList.FindAll(p => p.Name == name);
            return data;
        }

        public bool EnrollStudent(Student sObj)
        {
            bool flag = false;
            if (sObj != null)
            {
                StudentList.Add(sObj);
                flag = true;
            }
            return flag;
        }

        public bool UpdateStudentDetails(int id, Student newObj)
        {
            throw new NotImplementedException();
        }

        public bool DropStudentDetails(int id)
        {
            throw new NotImplementedException();
        }

        public Student
    }
}
