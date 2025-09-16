namespace WA_MVC_StandBlog.Models;

public class Contact 
    : BaseEntity
{
    public required string Name { get; set; }
    public required string Email { get; set; }
    public required string  Subject { get; set; }
    public required string Message { get; set; }
}