namespace WA_MVC_StandBlog.Models;

public class Blog : 
    BaseEntity
{
    public Guid CategoryId { get; set; }
    public required string Title { get; set; }
    public required string Post { get; set; }
    
    //Navigation Property
   
    public Category? Category { get; set; }
    public ICollection<Comment>? Comments { get; set; }
    public ICollection<BlogTag>? Tags { get; set; }

}
