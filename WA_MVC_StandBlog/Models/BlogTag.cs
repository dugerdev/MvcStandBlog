namespace WA_MVC_StandBlog.Models;

public class BlogTag 
    : BaseEntity
{
    public Guid BlogId { get; set; }
    public Guid TagId { get; set; }

    //Navigation Prop

    public Blog? Blog { get; set; }
    public Tag? Tag { get; set; }

}
