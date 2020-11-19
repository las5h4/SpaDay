using System;
using System.ComponentModel.DataAnnotations;

namespace SpaDay.ViewModels
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "Must provide username")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "Must be between 5 and 15 characters")]
        public string Username { get; set; }

        [EmailAddress(ErrorMessage = "Invaid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter password")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Passwords must be between 6 and 20 characters")]
        [Compare("VerifyPassword", ErrorMessage = "Passwords did not match.")]
        [RegularExpression(@"^[a-zA-Z0-9]+$")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please verify password")]
        public string VerifyPassword { get; set; }
    }
}
