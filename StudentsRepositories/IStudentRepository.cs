using UniversityMenuApp.Models;

namespace UniversityMenuApp.Repositories;

public interface IStudentRepository
{
    List<Student> GetAll();

    void Add(Student student);
}