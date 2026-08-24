/*
Print a Multiplication Table**
Create a function `MultiplicationTable()` with **no arguments and no return type**.

The function should print the multiplication table of `5` from `1` to `10`.
*/

public class Question18
{
    public void MultiplicationTable()
    {
        for(int a = 5; a <=5 ; a++)
        {
            for (int b=1; b <= 10; b++)
            {
                int c = a*b;
                Console.WriteLine($"{a}*{b}={c}");
            }
        }
    }
}