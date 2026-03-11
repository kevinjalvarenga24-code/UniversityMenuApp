using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityMenuApp.Models;

namespace UniversityMenuApp.Repositories
{
    public class StudentsRepository : IStudentRepository
    {
        public List<Student> GetAllStudents()
        {
            {
                return new List<Student>
        {
                  new() { Id = 1, Nombre = "Kevin" },
                  new() { Id = 2, Nombre = "Jose"},
                  new() { Id = 3, Nombre = "Adriana" },
                  new() { Id = 4, Nombre = "Glenda"},
        };
            }
        }

    }
}



