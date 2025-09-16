namespace WA_MVC_StandBlog.Models;

public class Tag 
    : BaseEntity
{
    public required string Name { get; set; }

    //Naviogation Property
    public ICollection<BlogTag>? Blogs { get; set; }

}
