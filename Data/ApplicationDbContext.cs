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
    }
}
