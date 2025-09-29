namespace WA_MVC_StandBlog.Models.Entities
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }

        public DateTimeOffset CreatedOn { get; set; }

        public DateTimeOffset? UpdatedOn { get; set; }

        public DateTimeOffset? DeletedOn { get; set; }

        public bool IsDeleted { get; set; } 
    }
}
