//Determine whether a number is divisible by both 5 and 11.


public class Question15
{
    public void DivisibleBy11Or5()
    {
        int num;
        Console.WriteLine($"Enter a number");
        num=Convert.ToInt32(Console.ReadLine());

        if (num % 5 == 0 && num % 11 == 0)
        {
            Console.WriteLine($"The number is divisible by 5 and 11");
        }
        else
        {
            Console.WriteLine($"The number is  not divisible by both 5 and 11");
        }

    }
}