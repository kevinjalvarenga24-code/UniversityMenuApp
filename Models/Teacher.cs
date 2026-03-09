namespace UniversityMenuApp.Models;

public class Teacher
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }

    public Teacher()
    {
        FullName = "";
        Email = "";
    }

    public Teacher(int id, string fullName, string email)
    {
        Id = id;
        FullName = fullName;
        Email = email;
    }
}