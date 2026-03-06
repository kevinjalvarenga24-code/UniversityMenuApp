using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using UniversityMenuApp.Models;

namespace UniversityMenuApp.ViewModels;

public partial class TeachersViewModel: ObservableObject
    {

    public ObservableCollection<Teacher>Teachers { get; set; }

    [ObservableProperty]
    private Teacher? selectedTeacher;

    [ObservableProperty]
    private string formFullName = "";
    [ObservableProperty]
    private string formEmail = "";

    [ObservableProperty]
    private string statusMessage = "";

    public TeachersViewModel()
    {
        Teachers = new ObservableCollection<Teacher>();
        LoadTeacher();
    }

    private void LoadTeacher()
    {
        Teachers.Clear();

        Teachers.Add(new Teacher(1, "Kevin Alvarenga", "kevin@gmail.com"));
        Teachers.Add(new Teacher(2, "Maria Lopez", "maria@gmail.com"));
        Teachers.Add(new Teacher(3, "Carlos Ruiz", "carlos@gmail.com"));
    }
}


