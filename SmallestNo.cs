//Write a program to find the smaller of two numbers.


public class SmallestNo
{
    public void Number()
    {
        int num1;
        int num2;
        Console.WriteLine($"Enter the two numbers ");
        num1= Convert.ToInt32(Console.ReadLine());
        num2=  Convert.ToInt32(Console.ReadLine());

        if (num1 < num2)
        {
            Console.WriteLine($" number1:{num1} is smallest");
        }
        else  {
            Console.WriteLine($"number2:{num2} is smallest");
        }
    }
}