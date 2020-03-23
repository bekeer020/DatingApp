using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        
        [Required]
        [StringLength(20,MinimumLength=4,ErrorMessage="You must enter at least 4 character password")]
        public string Password { get; set; }
    }
}