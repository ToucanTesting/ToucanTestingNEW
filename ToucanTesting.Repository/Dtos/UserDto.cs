using System.ComponentModel.DataAnnotations;

namespace ToucanTesting.Repository.Dtos
{
    public class UserDto
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
    }

    public class PasswordUserDto : UserDto
    {
        [Required]
        public string Password { get; set; }
    }
}
