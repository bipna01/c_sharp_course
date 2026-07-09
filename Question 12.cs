//Declare variables for employee name, basic salary, bonus, and tax, then calculate the net salary.

public class Question12
{
    public void Employee()
    {
        string name = " shyam ";
        double salary = 500000;
        double bonus = 500;
        double tax = 2000;
        double NetSalary;
         NetSalary = salary-tax+bonus;
         Console.WriteLine($"the name of employee is {name} and his netsalary is{NetSalary}");
    }
}