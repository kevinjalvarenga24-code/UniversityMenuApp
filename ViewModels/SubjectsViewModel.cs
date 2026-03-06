
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using UniversityMenuApp.Models;

namespace UniversityMenuApp.ViewModels;

public partial class StudentsViewModel : ObservableObject
{
    public ObservableCollection<Subject> Subjects { get; set; }

    [ObservableProperty]
    private Student? selectedSubject;

    [ObservableProperty]
    private string formFullSubject = "";

    [ObservableProperty]
    private string formemail = "";

    [ObservableProperty]
    private string statusmessage = "";

}