//Input age and determine whether a person is eligible to vote (18 or above).

public class Vote
{
    public void Age()
    {
        int age;
        Console.WriteLine($"enter your age");
        age=Convert.ToInt32(Console.ReadLine());

        if (age >= 18)
        {
            Console.WriteLine($"you are  Eligibile to vote");
        }
        else
        {
            Console.WriteLine($"you are not eligible to vote");
        }
    }
}