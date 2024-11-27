using Microsoft.EntityFrameworkCore;
using ReviewSite.Model;

namespace ReviewSite.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<FriendshipQuestionnaire> FriendshipQuestionnaire { get; set; }
    }
}
