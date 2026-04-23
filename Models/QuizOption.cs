using System.ComponentModel.DataAnnotations;

namespace OnboardingApp.Models
{
    public class QuizOption
    {
        public int QuizOptionId { get; set; }

        [Required]
        public int QuizQuestionId { get; set; }

        [Required]
        [StringLength(300)]
        public string OptionText { get; set; } = string.Empty;

        public bool IsCorrect { get; set; }

        // Navigation properties
        public QuizQuestion QuizQuestion { get; set; } = null!;
        public ICollection<QuizAnswer> Answers { get; set; } = new List<QuizAnswer>();
    }
}
