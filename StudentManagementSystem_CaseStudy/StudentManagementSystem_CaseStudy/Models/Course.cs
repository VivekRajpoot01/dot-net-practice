using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagementSystem_CaseStudy.Models
{
    public class Course
    {
        public int CourseId { get; set; }

        public string CourseName { get; set; }

        public int Duration { get; set; }

        public decimal Fees { get; set; }

        public int DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }
    }
}
