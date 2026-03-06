using UniversityMenuApp.Models;

namespace UniversityMenuApp.Repositories;

public interface ITeacherRepository
{
    List<Teacher> GetAll();

    void Add(Teacher teacher);
}