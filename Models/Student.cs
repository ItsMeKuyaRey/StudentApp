using System.ComponentModel.DataAnnotations;

namespace StudentApp.Models;

public class Student
{
    public int Id { get; set; }

    [Required]
    public string FullName { get; set; } = string.Empty;

    public int Age { get; set; }
    public string Course { get; set; } = string.Empty;

}
