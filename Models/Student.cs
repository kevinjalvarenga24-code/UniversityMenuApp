namespace UniversityMenuApp.Models;

public class Student
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }

    public Student()
    {
        FullName = "";
        Email = "";
    }

    public Student(int id, string fullName, string email)
    {
        Id = id;
        FullName = fullName;
        Email = email;
    }
}