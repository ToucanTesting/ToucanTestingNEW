using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ToucanTesting.Repository.Dtos
{
    public class PasswordUserDto : UserDto
    {
        [Required]
        public string Password { get; set; }
    }
}
