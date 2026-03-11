using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityMenuApp.Models;


namespace UniversityMenuApp.Repositories;

public class AlumnoNotasRepository : IAlmunosNotasRepository
{
    public List<AlumnoNotas> GetAllAlumnosNotas()
    {
        return new List<AlumnoNotas>
        {
            new() { IdAlumnos = 1, IdAsignatura = 1, notas = 80 },
            new() { IdAlumnos = 2, IdAsignatura = 2, notas = 90 },
            new() { IdAlumnos = 3, IdAsignatura = 3, notas = 78 },
            new() { IdAlumnos = 4, IdAsignatura = 4, notas = 91 },
        };
    }
}