using System.ComponentModel.DataAnnotations;

namespace JWTAuthentication.Authentication
{
    public class RegisterModel
    {
        [Required(ErrorMessage ="username is required")]
        public string Username { get; set; }

        [Required(ErrorMessage ="email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage ="password is required")]
        public string Password { get; set; }
    }
}
