public class Array10
{
    public void JaggedOneD()
    {
        int [][] array= new int[3][];
        array[0]=new int[2]{1,2};
        array[1]=new int[3]{1,2,3};
        array[2]=new int[4]{1,2,3,4};

        for(int i = 0; i < array.Length; i++)
        {
            for(int j = 0; j < array[i].Length; j++)
            {
                Console.Write(array[i][j]+"");
            }
             Console.WriteLine();
        }
       
    }
}