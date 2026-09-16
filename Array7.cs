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
         for(int x = 0; x <numbers.GetLength(depth) ; x++)
        {
            for(int y = 0; y <numbers.GetLength(row); y++)
            {
                for(int z = 0; z <numbers.GetLength(column); z++)
                {
                    Console.Write(numbers[x,y,z]);
                }
                Console.WriteLine();
            }
        }

        Console.WriteLine($"Display elements");
        for(int x=0;x<0;x++){
            
        }



    }
}