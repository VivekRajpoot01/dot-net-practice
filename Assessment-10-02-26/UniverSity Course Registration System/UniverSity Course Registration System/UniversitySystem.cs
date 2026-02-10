using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Course_Registration_System
{
    // =========================
    // University System Class
    // =========================
    public class UniversitySystem
    {
        public Dictionary<string, Course> AvailableCourses { get; private set; }
        public Dictionary<string, Student> Students { get; private set; }

        public UniversitySystem()
        {
            AvailableCourses = new Dictionary<string, Course>();
            Students = new Dictionary<string, Student>();
        }

        public void AddCourse(string code, string name, int credits, int maxCapacity = 50, List<string> prerequisites = null)
        {
            // TODO:
            // 1. Throw ArgumentException if course code exists
            // 2. Create Course object
            // 3. Add to AvailableCourses
            if (courses.ContainsKey(code))
            {
                throw new ArgumentException("Course already exists");
            }

            courses.Add(code, new Course(code, name, credits, capacity, prereq));
        }

        public void AddStudent(string id, string name, string major, int maxCredits = 18, List<string> completedCourses = null)
        {
            // TODO:
            // 1. Throw ArgumentException if student ID exists
            // 2. Create Student object
            // 3. Add to Students dictionary
            if (students.ContainsKey(id))
            {
                throw new ArgumentException("Student already exists");
            }

            students.Add(id, new Student(id, name, major, maxCredits, completed));
        }

        public bool RegisterStudentForCourse(string studentId, string courseCode)
        {
            // TODO:
            // 1. Validate student and course existence
            // 2. Call student.AddCourse(course)
            // 3. Display meaningful messages
            if (!students.ContainsKey(studentId) || !courses.ContainsKey(courseCode))
            {
                Console.WriteLine("Invalid student or course");
                return;
            }

            
        }

        public bool DropStudentFromCourse(string studentId, string courseCode)
        {
            // TODO:
            // 1. Validate student existence
            // 2. Call student.DropCourse(courseCode)
            if (students.ContainsKey(studentId))
            {
                if (students[studentId].DropCourse(courseCode))
                {
                    Console.WriteLine("Course deleted succesfully");
                }
                else
                {
                    Console.WriteLine("Course not found");
                }
            }

        public void DisplayAllCourses()
        {
            // TODO:
            // Display course code, name, credits, enrollment info
            foreach(Course c in AvailableCourses.Values)
            {
                Console.WriteLine($"Course Code: {c.CourseCode}");
                Console.WriteLine($"Course Name: {c.CourseName}");
                Console.WriteLine($"Credits {c.Credits}");
            }
        }

        public void DisplayStudentSchedule(string studentId)
        {
            // TODO:
            // Validate student existence
            // Call student.DisplaySchedule()
            throw new NotImplementedException();
        }

        public void DisplaySystemSummary()
        {
            // TODO:
            // Display total students, total courses, average enrollment
            Console.WriteLine("System Summary:");

            Console.WriteLine("Total Students: " + Students.Count);
            Console.WriteLine("Total Courses: " + AvailableCourses.Count);
        }
    }
}
