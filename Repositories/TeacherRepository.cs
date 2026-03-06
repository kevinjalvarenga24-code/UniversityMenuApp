using UniversityMenuApp.Models;

namespace UniversityMenuApp.Repositories;

public class TeacherRepository : ITeacherRepository
{
    private List<Teacher> teachers = new();

    public List<Teacher> GetAll()
    {
        return teachers;
    }

    public void Add(Teacher teacher)
    {
        teachers.Add(teacher);
    }
}