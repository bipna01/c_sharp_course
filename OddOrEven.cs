//Write a C# program that checks whether a given integer is even or odd.

public class OddOrEven
{
    public void check()
    {
        int num;
        Console.WriteLine($"enter a number to check odd or even");
        num=Console.Read();

        if (num % 2 == 0)
        {
            Console.WriteLine($"the enter number is even ");
        }
        else
        {
            Console.WriteLine($"the enter number is odd");
        }
    }
    
}