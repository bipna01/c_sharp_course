using System.Net.Http.Headers;
using System.Runtime.InteropServices;

public class Jagged2D
{
    public void TwoD()
    {
        int [][,] jagged= new int[2][,]
        {
            new int [,]{{2,3},{3,4,}},

            new int [,]{{3,4,5},{5,6,7}},
        };

       for(int a= 0; a < jagged.Length; a++)
        {
            for( int i = 0; i < jagged[a].GetLength(0); i++)
            {
                for(int j = 0; j < jagged[a].GetLength(1); j++) 
                {
                    Console.Write(jagged[a][i,j]);
                }
            }
            Console.WriteLine();
        } 
        Console.WriteLine();

    }
}