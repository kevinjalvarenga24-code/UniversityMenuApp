using UniversityMenuApp.Models;

namespace UniversityMenuApp.Repositories;

public class StudentRepository : IStudentRepository
{
    private List<Student> students = new();

    public List<Student> GetAll()
    {
        return students;
    }

    public void Add(Student student)
    {
        students.Add(student);
    }
}