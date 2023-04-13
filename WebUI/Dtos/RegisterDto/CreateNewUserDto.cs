using System.ComponentModel.DataAnnotations;

namespace WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage ="Name space required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "SurName space required")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "City space required")]
        public string City { get; set; }

        [Required(ErrorMessage = "UserName space required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Mail space required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password space required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Password Repeat space required")]
        [Compare("Password",ErrorMessage ="Passwords don't match")]
        public string ConfirmPassword { get; set; }
    }
}
