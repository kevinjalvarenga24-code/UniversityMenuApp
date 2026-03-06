using ClosedXML.Excel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;
using System.Collections.ObjectModel;
using UniversityMenuApp.Models;

namespace UniversityMenuApp.ViewModels;

public partial class StudentsViewModel : ObservableObject
{
    public ObservableCollection<Student> Students { get; set; }

    [ObservableProperty]
    private Student? selectedStudent;

    [ObservableProperty]
    private string formFullName = "";

    [ObservableProperty]
    private string formEmail = "";

    [ObservableProperty]
    private string statusMessage = "";

    public StudentsViewModel()
    {
        Students = new ObservableCollection<Student>(); 
        LoadStudent();
    }

    private void LoadStudent()
    {
        Students.Clear();

        Students.Add(new Student(1, "Kevin Alvarenga", "kevin@gmail.com"));
        Students.Add(new Student(2, "Maria Lopez", "maria@gmail.com"));
        Students.Add(new Student(3, "Carlos Ruiz", "carlos@gmail.com"));
    }
    [RelayCommand]
    private void ExportExcel()
    {
        var dialog = new SaveFileDialog
        {
            Filter = "Excel Workbook(*.xlsx)|*.xlsx",
            FileName = "Students.xlsx"
        };
        if (dialog.ShowDialog()!=true)
            return;

        using var wb=new XLWorkbook();
        var ws = wb.Worksheets.Add("Students");

        ws.Cell(1, 1).Value = "Id";
        ws.Cell(1, 2).Value = "Nombre";
        ws.Cell(1,3).Value= "Email";
        ws.Row(1).Style.Font.Bold = true;

        int row = 2;
        foreach(var x in Students)
        {
            ws.Cell(row, 1).Value=x.Id;
            ws.Cell(row, 2).Value = x.FullName;
            ws.Cell(row, 3).Value = x.Email;
            row++;

        }    
        ws.Columns().AdjustToContents();
        wb.SaveAs(dialog.FileName);






    }
}