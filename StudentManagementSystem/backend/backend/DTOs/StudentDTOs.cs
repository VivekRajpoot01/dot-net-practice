using System.ComponentModel.DataAnnotations;

namespace backend.DTOs
{
    public class StudentCreateDTO
    {
        [Required]
        public string Name { get; set; }

        [Range(18, 60)]
        public int Age { get; set; }

        [Required]
        public string Course { get; set; }
    }

    public class StudentResponseDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }
    }
}
