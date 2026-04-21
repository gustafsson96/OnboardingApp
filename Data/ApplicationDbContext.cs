using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnboardingApp.Models;

namespace OnboardingApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Module> Modules { get; set; }
        public DbSet<ModuleSection> ModuleSections { get; set; }
        public DbSet<ChecklistItem> ChecklistItems { get; set; }
        public DbSet<UserModuleProgress> UserModuleProgresses { get; set; }
        public DbSet<UserChecklistItemStatus> UserChecklistItemStatus { get; set; }
        public DbSet<UserNote> UserNotes { get; set; }
    }
}
