using System.ComponentModel.DataAnnotations;

namespace ToucanTesting.Application.Domain.Users
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
