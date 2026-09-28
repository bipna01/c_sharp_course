public class Array6
{
    public void Stringarray()
    {
        Console.WriteLine($"Enter the number of row");
        int row =int.Parse(Console.ReadLine());

        Console.WriteLine($"Enter the number of column");
        int column=int.Parse(Console.ReadLine());

        String[,] numbers = new string[row,column];
         Console.WriteLine("Enter the elements of array");
        for(int i =0;i<numbers.GetLength(0); i++)
        {
            for(int j=0;j< numbers.GetLength(1); j++)
            {
                numbers [i,j]=Console.ReadLine();
               
            }
             
        }     
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                Console.Write(numbers[i, j] + " ");
            }

            Console.WriteLine();
        }

    }
}
