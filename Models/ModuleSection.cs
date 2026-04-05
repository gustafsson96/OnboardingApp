// Represents a section within a module.
namespace OnboardingApp.Models
{
    public class ModuleSection
    {
        public int ModuleSectionId { get; set; }
        public int ModuleId { get; set; }
        public Module? Module { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public int OrderIndex { get; set; }
    }
}
