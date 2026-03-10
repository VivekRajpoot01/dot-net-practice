using System.ComponentModel.DataAnnotations;

namespace EFCoreMVCWebDemo.Models
{
    public class Department
    {
        [Key]
        public int DeptId { get; set; }
        [Required(ErrorMessage ="Mandatory Field")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Mandatory Field")]
        public string Location { get; set; }

        // One to Many Relation
        public ICollection<Employee> employees { get; set; }
    }
}
