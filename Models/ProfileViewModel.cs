using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace LearnSignLanguageApp.Models
{
    public class ProfileViewModel
    {
        public string Username { get; set; }
        public string Email { get; set; }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        public string ProfilePictureUrl { get; set; }
    }
}