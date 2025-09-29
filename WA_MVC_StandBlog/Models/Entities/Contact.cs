using WA_MVC_StandBlog.Models.Entities;

namespace WA_MVC_StandBlog.Models.Entities;

public class Contact 
    : BaseEntity
{
    public required string Name { get; set; }
    public required string Email { get; set; }
    public required string  Subject { get; set; }
    public required string Message { get; set; }
}