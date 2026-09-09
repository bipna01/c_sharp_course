//Wap in c# to store the numbers in 1d array from user and display their elements

public class Array1
{
    public  void OneD()
    {
        int[] num=new int[3];
        Console.WriteLine($"Enter three numbers");
         for( int n = 1; n <= 3; n++)
        {
            Console.WriteLine("Number"+n+":");
            num[n] = Convert.ToInt32(Console.ReadLine());
        }
    }
}