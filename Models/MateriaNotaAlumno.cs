using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityMenuApp.Models;

public class MateriaNotaAlumno
{
    public int IdAlumno { get; set; }
    public string Nombre { get; set; }
    public int IdAsignatura { get; set; } 
    public string Asignatura { get; set; }

    public double Nota { get; set; }
}