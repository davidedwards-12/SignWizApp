using Microsoft.AspNetCore.Identity;

namespace LearnSignLanguageApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        // The website does not get First or Last name from users.
        // This was a test to see what and what does not work.
        // Can maybe use the ProfilePictureUrl in the future.
        
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        //public string ProfilePictureUrl { get; set; }
    }
}
