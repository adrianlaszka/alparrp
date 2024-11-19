using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AlparRP.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<DiscordUser> DiscordUsers { get; set; }
        public DbSet<UserActivityLog> UserActivityLogs { get; set; }
    }
}
