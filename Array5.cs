public class Array5
{
    public  void display2d()
    {
        Console.WriteLine($"Enter the number of row");
        int row =int.Parse(Console.ReadLine());

        Console.WriteLine($"Enter the number of column");
        int column=int.Parse(Console.ReadLine());

        int[,] numbers= new int [row ,column];

        Console.WriteLine("Enter the elements of array");
        for(int i =0;i<numbers.GetLength(0); i++)
        {
            for(int j=0;j< numbers.GetLength(1); j++)
            {
                numbers [i,j]= Convert.ToInt32(Console.ReadLine());

              Console.Write(numbers[i, j] + " ");  
            }
            Console.WriteLine("");
        }

    }
}