using Microsoft.EntityFrameworkCore;
using System.Reflection;
using WA_MVC_StandBlog.Models.Entities;

namespace WA_MVC_StandBlog.Data
{
    /// <summary>
    /// StandBlog uygulaması için Entity Framework DbContext sınıfı
    /// </summary>
    public class StandBlogContext : DbContext
    {
        public StandBlogContext(DbContextOptions options) : base(options)
        {
        }

        protected StandBlogContext()
        {
        }

        // Veritabanı tabloları
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogTag> BlogTags { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Tag> Tags { get; set; }

        /// <summary>
        /// Model yapılandırmalarını uygular
        /// </summary>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Tüm IEntityTypeConfiguration sınıflarını otomatik olarak uygula
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
