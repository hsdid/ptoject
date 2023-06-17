using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data
{
    public class WebForumContext : DbContext
    {
        public WebForumContext (DbContextOptions<WebForumContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplication1.Models.Category> Category { get; set; } = default!;

        public DbSet<WebApplication1.Models.User>? User { get; set; }

        public DbSet<WebApplication1.Models.Post>? Post { get; set; }

        public DbSet<WebApplication1.Models.Comment>? Comment { get; set; }

        public DbSet<WebApplication1.Models.SavedPost>? SavedPost { get; set; }
    }
}
