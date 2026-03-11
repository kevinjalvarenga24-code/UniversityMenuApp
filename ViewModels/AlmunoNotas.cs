using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;
using System.Collections.ObjectModel;
using System.Linq;
using UniversityMenuApp.Models;

namespace UniversityMenuApp.ViewModels;

public partial class AlumnoNotas : ObservableObject
{
    public ObservableCollection<AlumnoNotas> alumnoNotas { get; set; }

    [ObservableProperty]
    private AlumnoNotas? selectedStudent;

    [ObservableProperty]
    private string formFullName = "";

    [ObservableProperty]
    private string formEmail = "";

    [ObservableProperty]
    private string statusMessage = "";

    public AlumnoNotas()
    {
        alumnoNotas = new ObservableCollection<AlumnoNotas>();
        LoadAlumnonotas();
    }

    private void LoadAlumnonotas()
    {
        alumnoNotas.Clear();

      
    }
}