// Represents a user's progress for a specific module.
namespace OnboardingApp.Models
{
    public class UserModuleProgress
    {
        public int UserModuleProgressId { get; set; }
        public string UserId { get; set; } = string.Empty;
        public ApplicationUser? User { get; set; }
        public int ModuleId { get; set; }
        public Module? Module { get; set; }
        public int ProgressPercent { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime? CompletedAt { get; set; }
    }
}
