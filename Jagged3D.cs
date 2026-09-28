public class Jagged3D
{
    public void ThreeD()
    {
        int  [] [, ,]jagged=new int[][,,]
        {
            new int[,,]
            {
                {{1,2},{2,3}}
                

            },
         new int [,,]

            {
                {{1,2,3},{4,5,6}}
            }
        };

        for(int a = 0; a < jagged.Length; a++)
        {
            for(int i = 0; i < jagged[a].GetLength(0); i++)
            {
                for(int j=0;j < jagged[a].GetLength(1); j++)
                {
                    for(int k = 0; k < jagged[a].GetLength(2); k++)
                    {
                        Console.Write(jagged[a][i,j,k]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

    }
}