using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistrationAndLogin.Models
{
    public class UserLogin
    {
        [Display(Name = "Email ID:")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Az Email ID mező kitöltése kötelező")]
        public string EmailID { get; set; }

        [Display(Name = "Jelszó:")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "A jelszó kitöltése kötelező.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me:")]
        public bool RememberMe { get; set; }

    }
}