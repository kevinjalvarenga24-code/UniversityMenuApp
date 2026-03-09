using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Linq;
using UniversityMenuApp.Models;

namespace UniversityMenuApp.ViewModels;

public partial class TeachersViewModel : ObservableObject
{
    public ObservableCollection<Teacher> Teachers { get; set; }

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
        Teachers.Add(new Teacher(2, "Laura", "lau@gmail.com"));
        Teachers.Add(new Teacher(3, "Juan pablo", "pelon@gmail.com"));
    }

    partial void OnSelectedTeacherChanged(Teacher? value)
    {
        if (value != null)
        {
            FormFullName = value.FullName;
            FormEmail = value.Email;
        }
    }

    [RelayCommand]
    private void AddTeacher()
    {
        if (string.IsNullOrWhiteSpace(FormFullName) || string.IsNullOrWhiteSpace(FormEmail))
        {
          
            return;
        }

        int newId = Teachers.Count > 0 ? Teachers.Max(x => x.Id) + 1 : 1;

        Teachers.Add(new Teacher(newId, FormFullName, FormEmail));

        FormFullName = "";
        FormEmail = "";
       
    }

    [RelayCommand]
    private void UpdateTeacher()
    {
        if (SelectedTeacher == null)
        {
           
            return;
        }

        SelectedTeacher.FullName = FormFullName;
        SelectedTeacher.Email = FormEmail;

      
    }

    [RelayCommand]
    private void DeleteTeacher()
    {
        if (SelectedTeacher == null)
        {
          
            return;
        }

        Teachers.Remove(SelectedTeacher);

        FormFullName = "";
        FormEmail = "";
        SelectedTeacher = null;

       
    }
}