using UniversityMenuApp.Models;
using UniversityMenuApp.Repositories;

namespace UniversityMenuApp.Services;

public class MateriaNotaAlumnoService
{
    public List<MateriaNotaAlumno> ObtenerNotasDetalladas()
    {
        var alumnos = new StudentsRepository().GetAllStudents();
        var asignaturas = new AsignaturasRepository().GetAllAsignaturas();
        var notas = new AlumnoNotasRepository().GetAllAlumnosNotas();

        var resultado = (
            from nota in notas
            join alumno in alumnos on nota.IdAlumnos equals alumno.Id
            join asignatura in asignaturas on nota.IdAsignatura equals asignatura.Id
            select new MateriaNotaAlumno
            {
                IdAlumno = alumno.Id,
                Nombre = alumno.Nombre,
                IdAsignatura = asignatura.Id,
                Asignatura = asignatura.Asignatura,
                Nota = nota.notas
            }
        ).ToList();

        return resultado;
    }

    public List<MateriaNotaAlumno> NotasPorAlumnoID(int idAlumno)
    {
        var alumnos = new StudentsRepository().GetAllStudents();
        var asignaturas = new AsignaturasRepository().GetAllAsignaturas();
        var notas = new AlumnoNotasRepository().GetAllAlumnosNotas();

        var resultado = (
            from nota in notas
            join alumno in alumnos on nota.IdAlumnos equals alumno.Id
            join asignatura in asignaturas on nota.IdAsignatura equals asignatura.Id
            where alumno.Id == idAlumno
            select new MateriaNotaAlumno
            {
                IdAlumno = alumno.Id,
                Nombre = alumno.Nombre,
                IdAsignatura = asignatura.Id,
                Asignatura = asignatura.Asignatura,
                Nota = nota.notas
            }
        ).ToList();

        return resultado;
    }

    public List<MateriaNotaAlumno> NotasPorAsignaturaID(int idAsignatura)
    {
        var alumnos = new StudentsRepository().GetAllStudents();
        var asignaturas = new AsignaturasRepository().GetAllAsignaturas();
        var notas = new AlumnoNotasRepository().GetAllAlumnosNotas();

        var resultado = (
            from nota in notas
            join alumno in alumnos on nota.IdAlumnos equals alumno.Id
            join asignatura in asignaturas on nota.IdAsignatura equals asignatura.Id
            where asignatura.Id == idAsignatura
            select new MateriaNotaAlumno
            {
                IdAlumno = alumno.Id,
                Nombre = alumno.Nombre,
                IdAsignatura = asignatura.Id,
                Asignatura = asignatura.Asignatura,
                Nota = nota.notas
            }
        ).ToList();

        return resultado;
    }

}