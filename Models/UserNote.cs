// Represents a note created by a user.
namespace OnboardingApp.Models
{
    public class UserNote
    {
        public int UserNoteId { get; set; }
        public string UserId { get; set; } = string.Empty;
        public ApplicationUser? User { get; set; }
        public int? ChecklistItemId { get; set; }
        public ChecklistItem? ChecklistItem { get; set; }
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
