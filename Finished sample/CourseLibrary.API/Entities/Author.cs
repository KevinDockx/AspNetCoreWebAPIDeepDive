using System.ComponentModel.DataAnnotations;

namespace CourseLibrary.API.Entities;

public class Author(string firstName, string lastName, string mainCategory)
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string FirstName { get; set; } = firstName;

    [Required]
    [MaxLength(50)]
    public string LastName { get; set; } = lastName;

    [Required]
    public DateTimeOffset DateOfBirth { get; set; }

    public DateTimeOffset? DateOfDeath { get; set; }

    [Required]
    [MaxLength(50)]
    public string MainCategory { get; set; } = mainCategory;

    public ICollection<Course> Courses { get; set; }
        = new List<Course>();
}

