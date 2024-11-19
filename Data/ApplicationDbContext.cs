using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AlparRP.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<DiscordUser> DiscordUsers { get; set; }
        public DbSet<UserActivityLog> UserActivityLogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Ha nem lenne automatikusan beállítva, expliciten állítsuk be az elsődleges kulcsot.
            modelBuilder.Entity<UserActivityLog>()
                .HasKey(u => u.LogId); // Az 'Id' legyen az elsődleges kulcs.
        }
    }
}
