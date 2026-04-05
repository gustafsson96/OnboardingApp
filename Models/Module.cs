// Represents an onboarding module. One module can contain multiple sections.
namespace OnboardingApp.Models
{
    public class Module
    {
        public int ModuleId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int OrderIndex { get; set; }

        public ICollection<ModuleSection> Sections { get; set; } = new List<ModuleSection>();
        public ICollection<UserModuleProgress> UserProgress { get; set; } =
            new List<UserModuleProgress>();
    }
}
