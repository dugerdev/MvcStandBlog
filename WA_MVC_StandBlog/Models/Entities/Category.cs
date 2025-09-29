using WA_MVC_StandBlog.Models.Entities;

namespace WA_MVC_StandBlog.Models.Entities;

public class Category 
    : BaseEntity
{
    public required string  Name { get; set; }

    //Navigation Property
    public ICollection<Blog>? Blogs { get; set; }

}
