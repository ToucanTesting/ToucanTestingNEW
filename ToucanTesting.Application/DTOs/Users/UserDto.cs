using System.ComponentModel.DataAnnotations;

namespace ToucanTesting.Application.DTOs.Users
{
    public class UserDto
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
