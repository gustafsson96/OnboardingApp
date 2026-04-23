using System.ComponentModel.DataAnnotations;

namespace OnboardingApp.Models
{
    public class QuizAttempt
    {
        public int QuizAttemptId { get; set; }

        [Required]
        public int ModuleId { get; set; }

        [Required]
        public string UserId { get; set; } = string.Empty;

        public DateTime StartedAt { get; set; } = DateTime.UtcNow;
        public DateTime? CompletedAt { get; set; }

        public int Score { get; set; }
        public int TotalQuestions { get; set; }

        public bool Passed { get; set; }

        // Navigation properties
        public Module Module { get; set; } = null!;
        public ApplicationUser User { get; set; } = null!;
        public ICollection<QuizAnswer> Answers { get; set; } = new List<QuizAnswer>();
    }
}
