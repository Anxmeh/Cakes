using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cakes.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z'][a-zA-Z-' ]+[a-zA-Z']?$", ErrorMessage = "Incorrect symbols")]
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z'][a-zA-Z-' ]+[a-zA-Z']?$", ErrorMessage = "Incorrect symbols")]
        [Display(Name = "MiddleName")]
        public string MiddleName { get; set; }


        [Required]
        [RegularExpression(@"^[a-zA-Z'][a-zA-Z-' ]+[a-zA-Z']?$", ErrorMessage = "Incorrect symbols")]
        [Display(Name = "LastName")]
        public string LastName { get; set; }


        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string PasswordConfirm { get; set; }
    }
}
