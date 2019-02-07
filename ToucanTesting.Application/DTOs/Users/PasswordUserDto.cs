using System.ComponentModel.DataAnnotations;

namespace ToucanTesting.Application.DTOs.Users
{
    public class PasswordUserDto : UserDto
    {
        [Required]
        public string Password { get; set; }
    }
}