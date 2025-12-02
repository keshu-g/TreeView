using Microsoft.EntityFrameworkCore;
using TreeView.Models;

namespace TreeView.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Node> Nodes { get; set; }
    }
}
