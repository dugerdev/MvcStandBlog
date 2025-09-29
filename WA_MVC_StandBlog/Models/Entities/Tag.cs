using WA_MVC_StandBlog.Models.Entities;

namespace WA_MVC_StandBlog.Models.Entities;

public class Tag 
    : BaseEntity
{
    public required string Name { get; set; }

    //Naviogation Property
    public ICollection<BlogTag>? Blogs { get; set; }

}
