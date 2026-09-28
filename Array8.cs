public class Array8{
    public void StringThreed()
    {
         Console.WriteLine($"Enter the number of depth");
        int depth = int.Parse(Console.ReadLine());

         Console.WriteLine($"Enter the number of row");
        int row =int.Parse(Console.ReadLine());

        Console.WriteLine($"Enter the number of column");
        int column=int.Parse(Console.ReadLine());

        String[,,] num=new string[depth,row,column];

        Console.WriteLine($"Enter the elements of arrray");
        for(int x=0;x<num.GetLength(0);x++)
        {
            for(int y = 0; x < num.GetLength(1); y++)
            {
                for(int z = 0; x < num.GetLength(2); z++)
                {
                    
                }
            }
        }
          for (int x = 0; x < num.GetLength(0); x++)
        {
            for (int y= 0; y < num.GetLength(1); y++)
            {
                for(int z =0; z<num.GetLength(2); z++){
                Console.Write(num[x,y,z] + " ");
            }
            }

            Console.WriteLine();
        }


    }
    
}