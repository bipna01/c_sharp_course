/*Write a C# program to input the salary of 8 employees.
 Calculate the bonus according to the following rules:
Salary Bonus
Less than Rs. 20,000 20%
Rs. 20,000–39,999 15%
Rs. 40,000–59,999 10%
Rs. 60,000 and above 5%
Display the salary, bonus amount, and total salary after adding the bonus.WriteLine
*/

class Employee
{
    public void Salary()
    {
        double salary;
        double bonus;
        double total;

        for(int employee =1; employee <=8; employee ++)
        {
            Console.WriteLine($"Employee {employee}");
            Console.WriteLine($"enter your salary");
            salary=Convert.ToDouble(Console.ReadLine());

            if (salary < 20000)
            {
                bonus=20.0/100*salary ;
            }
            else if (salary>=20000 && salary < 39999)
            {
                bonus=15.0/100*salary;
                
            }
            else if (salary>=40000 && salary < 59999)
            {
                bonus=10.0/100*salary;
                
            }
            else {
            bonus=5.0/100*salary;
            
                }
                Console.WriteLine($"your bonus is :{bonus} ");
                  total = bonus + salary;
                Console.WriteLine($"total salary:{total}");
               
            }
    }
}
           

