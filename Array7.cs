using System.Data;

public class Array7
{
    public void ThreeD()
    {
         
        Console.WriteLine($"Enter the number of depth");
        int depth = int.Parse(Console.ReadLine());

         Console.WriteLine($"Enter the number of row");
        int row =int.Parse(Console.ReadLine());

        Console.WriteLine($"Enter the number of column");
        int column=int.Parse(Console.ReadLine());

         int[,,] numbers= new int [ depth,row ,column];

         Console.WriteLine("Enter the element of array");
         for(int x = 0; x <numbers.GetLength(0) ; x++)
        {
            for(int y = 0; y <numbers.GetLength(1); y++)
            {
                for(int z = 0; z <numbers.GetLength(2); z++)
                {
                    Console.WriteLine(numbers[x,y,z]);
                    numbers[x, y, z] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
        }

        Console.WriteLine($"Display elements");
        for(int x=0;x<numbers.GetLength(0);x++){
            for(int y = 0; y < numbers.GetLength(1); y++)
            {
                for(int z = 0; z < numbers.GetLength(2); z++)
                {
                    Console.Write(numbers[x,y,z] + " ");
                }
            }
            Console.WriteLine();
            
        }



    }
}