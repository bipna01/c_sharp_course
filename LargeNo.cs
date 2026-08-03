//Input two integers and display the larger one.


public class LargeNo
{
    public void Number()
    {
        int num1;
        int num2;
        Console.WriteLine($"Enter the two numbers ");
        num1= Convert.ToInt32(Console.ReadLine());
        num2=  Convert.ToInt32(Console.ReadLine());

        if (num1 > num2)
        {
            Console.WriteLine($" number1:{num1} is large");
        }
        else  {
            Console.WriteLine($"number2:{num2} is large");
        }
    }
}