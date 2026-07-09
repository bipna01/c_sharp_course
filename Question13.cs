//Store a student's information (Name, Roll No, Faculty, GPA) and display it in a formatted report.

public class Question13
{
    public void Student()
    {
        string name = "Bipana";
        int rollNo = 3;
        string faculty = "computer science";
        double gpa = 3.67;

        Console.WriteLine($" the information of student in a formatted report");
          
          Console.WriteLine($"...............Student Report................ ");
          Console.WriteLine($"Name:{name}");
          Console.WriteLine($"RollNo:{rollNo}");
          Console.WriteLine($"Faculty:{faculty}");
          Console.WriteLine($"GPA:{gpa}");
    }
}