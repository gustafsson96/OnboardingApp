// Represents a checklist item for the user to complete during onboarding.
namespace OnboardingApp.Models
{
    public class ChecklistItem
    {
        public int ChecklistItemId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? Category { get; set; }
        public int OrderIndex { get; set; }

        public ICollection<UserChecklistItemStatus> UserChecklistItemStatuses { get; set; } =
            new List<UserChecklistItemStatus>();
        public ICollection<UserNote> Notes { get; set; } = new List<UserNote>();
    }
}
