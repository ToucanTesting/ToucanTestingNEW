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
}
