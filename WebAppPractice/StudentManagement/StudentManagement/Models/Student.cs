using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Please! enter Id")]
        public int Id { get; set; }
        
        public string FullName { get; set; }
        [RegularExpression(@"[a-zA-Z0-9_\.\-]+@+[a-z]+\.[a-z]{2,3}",ErrorMessage ="Enter a valid email")]
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Course { get; set; }
    }
}
