namespace UniversityMenuApp.Models;

public class Student
{
    public Student(object value)
    {
    }

    public Student(object value, string v1, string v2) : this(value)
    {
    }

    public int Id { get; set; }
    public string FullName { get; set; } = "";
    public string Email { get; set; } = "";
}
