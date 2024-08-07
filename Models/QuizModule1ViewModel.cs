using System.ComponentModel.DataAnnotations;

namespace LearnSignLanguageApp.Models
{
    public class QuizModule1ViewModel
    {
        [Required]
        public string Question1 { get; set; }

        [Required]
        public string Question2 { get; set; }

        // Add more questions as needed
    }
}
