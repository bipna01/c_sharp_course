//Swap the values of two variables using a third variable.

public class Question5
{
    public void Swap()
    {
        int x=4;
        int y=5;
        int z;
        z=y;
        y=x;
        x=z;
        Console.WriteLine($"the value of x and y afrer swapping is {x} and {y}");
    }
}