using System;
using System.ComponentModel.DataAnnotations;

namespace SpaDay.ViewModels
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "Username is required!")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "Username must be between 5 and 15 characters!")]
        public string Username { get; set; }

        [EmailAddress(ErrorMessage = "Not a valid email address. If you do not wish to submit an email address, leave this field blank.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required!")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Password must be bettween 6 and 20 characters!")]
        [Compare("VerifyPassword", ErrorMessage = "Passwords did not match! Try again.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please verify your password!")]
        public string VerifyPassword { get; set; }
    }
}
