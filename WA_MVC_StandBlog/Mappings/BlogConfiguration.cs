using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WA_MVC_StandBlog.Models;

namespace WA_MVC_StandBlog.Mappings;

public class BlogConfiguration : IEntityTypeConfiguration<Blog>
{
    public void Configure(EntityTypeBuilder<Blog> builder)
    {
        builder.ToTable("Blogs", "app");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.IsDeleted)
            .IsRequired()
            .HasDefaultValue(false); 

        builder.Property(x => x.CreatedOn)
            .IsRequired()
            .HasDefaultValueSql("GETUTCDATE()") 
            .ValueGeneratedOnAdd();

        builder.Property(x => x.Title)
            .IsRequired()
            .HasMaxLength(255);

        builder.HasIndex(x => x.Title)
            .IsUnique();

        builder.Property(x => x.Post)
            .IsRequired()
            .HasColumnType("ntext");

        builder.HasOne(b => b.Category)
            .WithMany(c => c.Blogs)
            .HasForeignKey(b => b.CategoryId);
    }
}
