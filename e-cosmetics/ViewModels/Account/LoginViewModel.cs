using System.ComponentModel.DataAnnotations;

namespace e_cosmetics.ViewModels.Account
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "The username is required!")]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "The password is required!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public bool RememberMe { get; set; }
    }
}
