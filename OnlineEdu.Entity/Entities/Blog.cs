namespace OnlineEdu.Entity.Entities;

public class Blog
{
    public int BlogId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public string ImageUrl { get; set; }
    public DateTime CreatedDate { get; set; }
    public int BlogCategoryId { get; set; }
    public BlogCategory BlogCategory { get; set; }
}