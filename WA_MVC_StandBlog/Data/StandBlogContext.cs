using Microsoft.EntityFrameworkCore;
using System.Reflection;
using WA_MVC_StandBlog.Models;

namespace WA_MVC_StandBlog.Data
{
    public class StandBlogContext : DbContext
    {
        public StandBlogContext(DbContextOptions options) : base(options)
        {
        }

        protected StandBlogContext()
        {
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogTag> BlogTags { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact>  Contacts { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
