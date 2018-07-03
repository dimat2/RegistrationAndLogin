using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistrationAndLogin.Models
{
    [MetadataType(typeof(UserMetaData))]
    public partial class Users
    {
        public string ConfirmPassword { get; set; }
    }

    public class UserMetaData
    {
        [Display(Name = "Keresztnév:")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "A keresztnév megadása kötelező.")]
        public string FirstName { get; set; }

        [Display(Name = "Családi név:")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "A családinév megadása kötelező.")]
        public string LastName { get; set; }

        [Display(Name = "Email ID:")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "AZ Email ID megadása kötelező.")]
        [DataType(DataType.EmailAddress)]
        public string EmailID { get; set; }

        [Display(Name = "Születési idő:")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Jelszó:")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "A jelszónak legalább 6 karakternek kell lennie.")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "A jelszó megadása kötelező.")]
        public string Password { get; set; }

        [Display(Name = "Jelszó még egyszer:")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "A jelszavak nem egyeznek.")]
        public string ConfirmPassword { get; set; }
    }
}