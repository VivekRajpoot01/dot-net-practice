using System.ComponentModel.DataAnnotations;

namespace EFCoreMVCWebDemo.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string Name { get; set; }
        public int age { get; set; }
        public string Address { get; set; }
        public int DeptId { get; set; }

        //Navigation Property
        public virtual Department Department { get; set; }
    }
}
