using UniversityMenuApp.Models;

namespace UniversityMenuApp.Repositories;

public interface IStudentRepository
{
    List<Student> GetAllStudents();

 
}