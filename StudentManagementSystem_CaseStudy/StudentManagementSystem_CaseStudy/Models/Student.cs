using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagementSystem_CaseStudy.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        public string StudentName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public int DepartmentId { get; set; }

        public int CourseId { get; set; }

        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }

        [ForeignKey("CourseId")]
        public Course Course { get; set; }
    }
}
