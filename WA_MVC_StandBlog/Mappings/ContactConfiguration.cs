using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WA_MVC_StandBlog.Models;

namespace WA_MVC_StandBlog.Mappings;

public class ContactConfiguration : IEntityTypeConfiguration<Contact>
{
    public void Configure(EntityTypeBuilder<Contact> builder)
    {
        builder.ToTable("Contacts", "app");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.IsDeleted)
            .IsRequired()
            .HasDefaultValue(false);

        builder.Property(x => x.CreatedOn)
            .IsRequired()
            .HasDefaultValueSql("GETUTCDATE()") 
            .ValueGeneratedOnAdd();

        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(128);

        builder.Property(x => x.Email)
            .IsRequired()
            .HasMaxLength(128);

        builder.Property(x => x.Subject)
            .IsRequired()
            .HasMaxLength(128);

        builder.Property(x => x.Message)
            .IsRequired()
            .HasMaxLength(500);
    }
}
