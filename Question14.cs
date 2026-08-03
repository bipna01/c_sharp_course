//Check whether a number is divisible by 5.

public class Question14
{
    public void DivisibleBy5()
    {
        int num;
        Console.WriteLine($"enter a number");

        num=Convert.ToInt32(Console.ReadLine());

        if (num % 5 == 0)
        {
            Console.WriteLine($"the number is disible by 5");
        }
        else
        {
            Console.WriteLine($"the number is not divisible by 5");
        }

    }
}