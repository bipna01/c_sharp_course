//Write a program to input a number and determine whether it is:

// Positive
//Negative
// Zero



public class PositiveNZ
{
    public void Check(){
        int num;
        Console.WriteLine($"Enter a number to check positive Negative or zero");

        num=Console.Read();

        if(num>0){
            Console.WriteLine($"the number is positive ");
        }
        else if(num < 0){
            Console.WriteLine($"the number is negative");
        }
        else
        {
            Console.WriteLine($"the number is zero");
        }

    }
    
}