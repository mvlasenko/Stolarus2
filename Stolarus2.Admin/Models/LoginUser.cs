using System.ComponentModel.DataAnnotations;

namespace Stolarus2.Admin.Models
{
    public class LoginUser
    {
        [Required]
        public string Login { get; set; }

        [Required]
        [DataType(DataType.Password)]
		[UIHint("Password")]
        public string Password { get; set; }
    }
}