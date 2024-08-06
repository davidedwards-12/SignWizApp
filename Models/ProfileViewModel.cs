using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace LearnSignLanguageApp.Models
{
    public class ProfileViewModel
    {
        public string Username { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        // Add any additional fields you need for the profile page
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Profile Picture URL")]
        public string ProfilePictureUrl { get; set; }

        // Add more fields as needed
    }
}