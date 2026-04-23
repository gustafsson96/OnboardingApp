using System.ComponentModel.DataAnnotations;

namespace OnboardingApp.Models
{
    public class QuizQuestion
    {
        public int QuizQuestionId { get; set; }

        [Required]
        public int ModuleId { get; set; }

        [Required]
        [StringLength(500)]
        public string QuestionText { get; set; } = string.Empty;

        public int OrderIndex { get; set; }

        // Navigation properties
        public Module Module { get; set; } = null!;
        public ICollection<QuizOption> Options { get; set; } = new List<QuizOption>();
        public ICollection<QuizAnswer> Answers { get; set; } = new List<QuizAnswer>();
    }
}
