using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ecosmetics.Services.Accounts.Models
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
