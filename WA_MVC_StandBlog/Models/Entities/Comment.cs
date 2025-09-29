using WA_MVC_StandBlog.Models.Entities;

namespace WA_MVC_StandBlog.Models.Entities;

public class Comment 
    : BaseEntity
{
    public Guid BlogId { get; set; }
    public required string Name { get; set; }
    public required string Email { get; set; }
    public required string Message { get; set; }

    //Navigation Property

    public Blog? Blog { get; set; }

}
