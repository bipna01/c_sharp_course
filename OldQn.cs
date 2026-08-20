using System.Transactions;

class OldQn
{
    public void Result()
    {
        double vp;
         double cn;
        double sep;
        double persentage;
        double total;

       


        for(int studentNo = 1; studentNo <=5 ; studentNo++)
        {
            Console.WriteLine($"StudentNo:"+studentNo);

             Console.WriteLine($"Enter the marks of vp" );
        vp=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Enter the marks of CN");
        cn=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Enter the marks of SEP");
        sep=Convert.ToInt32(Console.ReadLine()); 
            for( int subject = 1 ; subject<=3; subject++)


            {
                total=vp+cn+sep;
                persentage=(total/3000)*100;

                Console.WriteLine($"Total:" +total );
        Console.WriteLine($"Persentage"+persentage);
            }
        }
        
    }
}