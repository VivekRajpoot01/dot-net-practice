using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem_CaseStudy.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }

        [Required]
        public string DepartmentName { get; set; }

        public string Description { get; set; }
    }
}
