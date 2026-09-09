//Wap in c# to store the numbers in 2d array from user and display their elements

public class Array2
{
    public void TwoD()
    {
        int  [,] num =new int[2,3];
        Console.WriteLine($"Enter the elements of 2d array");
        for(int i = 0; i < 2; i++)
        {

             for(int j = 0; j < 3; j++)
        {
            
            num [i,j]= Convert.ToInt32(Console.ReadLine());

              Console.Write(num[i, j] + " ");  
        }
           
        }
        }
        }
       

    