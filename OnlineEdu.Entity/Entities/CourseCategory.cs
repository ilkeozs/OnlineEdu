namespace OnlineEdu.Entity.Entities;

public class CourseCategory
{
    public int CourseCategoryId { get; set; }
    public string Name { get; set; }
    public string Icon { get; set; }
    public string Description { get; set; }
    public bool IsShown { get; set; }
    public List<Course> Courses { get; set; } // This is a navigation property to the Course entity
}