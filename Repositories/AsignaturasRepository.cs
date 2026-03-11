using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityMenuApp.Models;

namespace UniversityMenuApp.Repositories
{
    public class AsignaturasRepository : IAsignaturasRepository
    {
        public List<Asignaturas> GetAllAsignaturas()
        {
            {
                return new List<Asignaturas>
        {
                  new() { Id = 1, Asignatura = "Matematicas" },
                  new() { Id = 2, Asignatura = "Sistemas"},
                  new() { Id = 3, Asignatura = "Programacion" },
                  new() { Id = 4, Asignatura = "Base de datos"},
        };
            }
        }

    }
}



