namespace WA_MVC_StandBlog.Models;

public class Category 
    : BaseEntity
{
    public required string  Name { get; set; }

    //Navigation Property
    public ICollection<Blog>? Blogs { get; set; }

}
